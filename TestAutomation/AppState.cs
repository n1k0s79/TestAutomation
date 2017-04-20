using System.Windows.Forms;

namespace TestAutomation
{
    /// <summary> A wrapper around a form to be run in-process </summary>
    public class AppState
    {
        public readonly Form MainForm;

        public AppState(Form mainForm)
        {
            this.MainForm = mainForm;
        }

        public void RunApp()
        {
            Application.Run(MainForm);
        }
    }
}
