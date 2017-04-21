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
            textTypes.Text = InProcess.Reflect(textPath.Text);
        }

        private void buttonLaunchAUT_Click(object sender, EventArgs e)
        {
            string path = "..\\..\\..\\AppUnderTest\\bin\\Debug\\AppUnderTest.exe";
            string formName = "AppUnderTest.MainForm";

            _AUTMainForm = InProcess.Launch(path, formName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var pt = new Point(10, 10);
            //InProcess.SetFormPropertyValue(_AUTMainForm, "Location", pt);
            var text = InProcess.GetControlPropertyValue(_AUTMainForm, "textOutput", "Text");

            InProcess.SetControlPropertyValue(_AUTMainForm, "textOutput", "Text", "text set from test harness, previous text was " + text);

            var ret = InProcess.InvokeMethod(_AUTMainForm, "buttonGenerateAll_Click", new object[] { null, EventArgs.Empty });
            var ret2 = InProcess.InvokeMethod(_AUTMainForm, "GetTestString", new object[] { });

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var o = new OpenFileDialog();
            o.Filter = "*.exe";
            if (o.ShowDialog() != DialogResult.OK) return;
            textPath.Text = o.FileName;

            textTypes.Text = InProcess.Reflect(o.FileName);
        }
    }
}