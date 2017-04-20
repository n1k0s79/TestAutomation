namespace TestHarness
{
    partial class frmTestHarness
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLaunchAUT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLaunchAUT
            // 
            this.buttonLaunchAUT.Location = new System.Drawing.Point(46, 54);
            this.buttonLaunchAUT.Name = "buttonLaunchAUT";
            this.buttonLaunchAUT.Size = new System.Drawing.Size(163, 45);
            this.buttonLaunchAUT.TabIndex = 0;
            this.buttonLaunchAUT.Text = "Launch AUT in-process";
            this.buttonLaunchAUT.UseVisualStyleBackColor = true;
            this.buttonLaunchAUT.Click += new System.EventHandler(this.buttonLaunchAUT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Move main form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTestHarness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 289);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLaunchAUT);
            this.Name = "frmTestHarness";
            this.Text = "Test harness";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunchAUT;
        private System.Windows.Forms.Button button1;
    }
}

