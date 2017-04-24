using System;
using System.Windows.Forms;
using TestAutomation;

namespace TestHarness
{
    public partial class frmAssemblyExplorer : Form
    {
        public frmAssemblyExplorer(string assemblyPath)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(assemblyPath)) this.ShowTypes(assemblyPath);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var o = new OpenFileDialog();
            o.Filter = "Executable files (*.exe)|*.exe|Library files (*.dll)|*.dll";
            if (o.ShowDialog() != DialogResult.OK) return;
            this.ShowTypes(o.FileName);
        }

        private void ShowTypes(string filename)
        {
            this.Text = "Assembly explorer: " + filename;
            textTypes.Text = Reflector.GetTypeDetails(filename);
        }
    }
}