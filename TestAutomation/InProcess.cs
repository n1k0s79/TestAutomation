using System;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

namespace TestAutomation
{
    public static class InProcess
    {
        public static Form Launch(string assemblyPath, string mainFormName)
        {
            var assembly = Assembly.LoadFrom(assemblyPath);
            var mainFormType = assembly.GetType(mainFormName);

            var ret = (Form)assembly.CreateInstance(mainFormType.FullName);

            var state = new AppState(ret);
            ThreadStart ts = state.RunApp;
            var thread = new Thread(ts);
            thread.SetApartmentState(ApartmentState.STA);
            thread.IsBackground = true;
            thread.Start();

            return ret;
        }

        delegate object GetFormPropertyValueDelegate(Form f, string propertyName);

        public static object GetFormPropertyValue(Form form, string propertyName)
        {
            if (form.InvokeRequired)
            {
                var delg = new GetFormPropertyValueDelegate(GetFormPropertyValue);
                return form.Invoke(delg, form, propertyName );
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
                form.Invoke(delg, form, propertyName, newValue);
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
                form.Invoke(delg, form, controlName, propertyName, newValue);
            }
            else
            {
                var type = form.GetType();
                var fieldInfo = type.GetField(controlName, Reflector.Flags);
                object control = fieldInfo.GetValue(form);
                var controlType = control.GetType();
                PropertyInfo propInfo = controlType.GetProperty(propertyName);
                propInfo.SetValue(control, newValue, null);
            }
        }

        delegate object GetControlPropertyValueDelegate(Form form, string controlName, string propertyName);

        public static object GetControlPropertyValue(Form form, string controlName, string propertyName)
        {
            if (form.InvokeRequired)
            {
                var delg = new GetControlPropertyValueDelegate(GetControlPropertyValue);
                return form.Invoke(delg, form, controlName, propertyName );
            }
            else
            {
                var formType = form.GetType();
                var fieldInfo = formType.GetField(controlName, Reflector.Flags);
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
                var ret = form.Invoke(delg, form, methodName, parms );
                are.WaitOne();
                return ret;
            }
            else
            {
                var type = form.GetType();
                var methodInfo = type.GetMethod(methodName, Reflector.Flags);
                var ret = methodInfo.Invoke(form, parms);
                are.Set();
                return ret;
            }
        }
    }
}