using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAutomation;

namespace TestHarness
{
    public partial class frmTestHarness : Form
    {
        private Form _AUTMainForm;

        public frmTestHarness()
        {
            InitializeComponent();
        }

        private void buttonLaunchAUT_Click(object sender, EventArgs e)
        {
            string path = "..\\..\\..\\AppUnderTest\\bin\\Debug\\AppUnderTest.exe";
            string formName = "AppUnderTest.MainForm";

            _AUTMainForm = InProcess.Launch(path, formName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pt = new Point(10, 10);
            InProcess.SetFormPropertyValue(_AUTMainForm, "Location", pt);
        }
    }
}