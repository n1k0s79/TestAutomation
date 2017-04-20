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
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
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

        delegate void SetFormPropertyValueHandler(Form f, string propertyName, object newValue);

        public static void SetFormPropertyValue(Form form, string propertyName, object newValue)
        {
            if (form.InvokeRequired)
            {
                var method = new SetFormPropertyValueHandler(SetFormPropertyValue);
                form.Invoke( method, new object[] { form, propertyName, newValue });
            }
            else
            {
                Type type = form.GetType();
                PropertyInfo propInfo = type.GetProperty(propertyName);
                propInfo.SetValue(form, newValue, null);
            }
        }
    }
}