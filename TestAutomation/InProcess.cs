using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

namespace TestAutomation
{
    public static class InProcess
    {
        public static Form Launch(string assemblyPath, string mainFormName)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            var types = assembly.GetTypes();
            Type mainFormType = assembly.GetType(mainFormName);

            var ret = (Form)assembly.CreateInstance(mainFormType.FullName);

            AppState state = new AppState(ret);
            ThreadStart ts = new ThreadStart(state.RunApp);
            Thread thread = new Thread(ts);
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();

            return ret;
        }

        public static string Reflect(string assemblyPath)
        {
            var assembly = Assembly.LoadFrom(assemblyPath);
            var types = assembly.GetTypes();
            string ret = string.Empty;
            foreach (Type type in types) ret += Reflect(type);

            return ret;
        }

        private static string Reflect(Type type)
        {
            var ret = string.Format("{0} ({1})\r\n", type.Name, type.BaseType.Name);

            var properties = GetProperties(type);
            ret += string.Format("    {0} Properties ({1})\r\n    --------------------\r\n", type.Name, properties.Length);
            foreach (var prop in properties) ret += string.Format("    {0} ({1})\r\n", prop.Name, prop.PropertyType.Name);
            ret += Environment.NewLine;

            var fields = GetFields(type);
            ret += string.Format("    {0} Fields ({1})\r\n    --------------------\r\n", type.Name, fields.Length);
            foreach (var field in fields) ret += string.Format("    {0} ({1})\r\n", field.Name, field.FieldType.Name);
            ret += Environment.NewLine;

            var methods = GetMethods(type);
            ret += string.Format("    {0} Methods ({1})\r\n    --------------------\r\n", type.Name, methods.Length);
            foreach (var method in methods) ret += string.Format("    {0} ({1})\r\n", method.Name, method.ReturnType.Name);
            ret += Environment.NewLine;

            return ret;
        }

        private static PropertyInfo[] GetProperties(Type type)
        {
            var baseProperties = type.BaseType.GetProperties(flags);
            var ret = new List<PropertyInfo>();
            foreach (var prop in type.GetProperties(flags))
                if (!baseProperties.Any(x => x.Name == prop.Name)) ret.Add(prop);

            return ret.ToArray();
        }

        private static FieldInfo[] GetFields(Type type)
        {
            var baseFields = type.BaseType.GetFields(flags);
            var ret = new List<FieldInfo>();
            foreach (var field in type.GetFields(flags))
                if (!baseFields.Any(x => x.Name == field.Name)) ret.Add(field);

            return ret.ToArray();
        }

        private static MethodInfo[] GetMethods(Type type)
        {
            var basemethods = type.BaseType.GetMethods(flags);
            var ret = new List<MethodInfo>();
            foreach (var method in type.GetMethods(flags))
                if (!basemethods.Any(x => x.Name == method.Name)) ret.Add(method);

            return ret.ToArray();
        }

        delegate object GetFormPropertyValueDelegate(Form f, string propertyName);

        public static object GetFormPropertyValue(Form form, string propertyName)
        {
            if (form.InvokeRequired)
            {
                var delg = new GetFormPropertyValueDelegate(GetFormPropertyValue);
                return form.Invoke(delg, new object[] { form, propertyName });
            }
            else
            {
                Type type = form.GetType();
                PropertyInfo propInfo = type.GetProperty(propertyName);
                object result = propInfo.GetValue(form, null);
                return result;
            }
        }

        delegate void SetFormPropertyValueDelegate(Form f, string propertyName, object newValue);

        public static void SetFormPropertyValue(Form form, string propertyName, object newValue)
        {
            if (form.InvokeRequired)
            {
                var delg = new SetFormPropertyValueDelegate(SetFormPropertyValue);
                form.Invoke(delg, new object[] { form, propertyName, newValue });
            }
            else
            {
                Type type = form.GetType();
                PropertyInfo propInfo = type.GetProperty(propertyName);
                propInfo.SetValue(form, newValue, null);
            }
        }

        delegate void SetControlPropertyValueDelegate(Form form, string controlName, string propertyName, object newValue);

        public static void SetControlPropertyValue(Form form, string controlName, string propertyName, object newValue)
        {
            if (form.InvokeRequired)
            {
                var delg = new SetControlPropertyValueDelegate(SetControlPropertyValue);
                form.Invoke(delg, new object[] { form, controlName, propertyName, newValue });
            }
            else
            {
                var type = form.GetType();
                var fieldInfo = type.GetField(controlName, flags);
                object control = fieldInfo.GetValue(form);
                var controlType = control.GetType();
                PropertyInfo propInfo = controlType.GetProperty(propertyName);
                propInfo.SetValue(control, newValue, null);
            }
        }

        static BindingFlags flags = BindingFlags.Public |
                                 BindingFlags.NonPublic |
                                    BindingFlags.Static |
                                  BindingFlags.Instance;

        delegate object GetControlPropertyValueDelegate(Form form, string controlName, string propertyName);

        public static object GetControlPropertyValue(Form form, string controlName, string propertyName)
        {
            if (form.InvokeRequired)
            {
                var delg = new GetControlPropertyValueDelegate(GetControlPropertyValue);
                return form.Invoke(delg, new object[] { form, controlName, propertyName });
            }
            else
            {
                var formType = form.GetType();
                var fieldInfo = formType.GetField(controlName, flags);
                object control = fieldInfo.GetValue(form);
                var controlType = control.GetType();
                var propInfo = controlType.GetProperty(propertyName);
                object result = propInfo.GetValue(control, null);
                return result;
            }
        }

        static AutoResetEvent are = new AutoResetEvent(false);

        delegate object InvokeMethodDelegate(Form f, string methodName, params object[] parms);

        public static object InvokeMethod(Form form, string methodName, params object[] parms)
        {
            if (form.InvokeRequired)
            {
                Delegate delg = new InvokeMethodDelegate(InvokeMethod);
                var ret = form.Invoke(delg, new object[] { form, methodName, parms });
                are.WaitOne();
                return ret;
            }
            else
            {
                var type = form.GetType();
                var methodInfo = type.GetMethod(methodName, flags);
                var ret = methodInfo.Invoke(form, parms);
                are.Set();
                return ret;
            }
        }
    }
}