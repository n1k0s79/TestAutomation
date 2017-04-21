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
            this.textTypes = new System.Windows.Forms.TextBox();
            this.textPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLaunchAUT
            // 
            this.buttonLaunchAUT.Location = new System.Drawing.Point(12, 41);
            this.buttonLaunchAUT.Name = "buttonLaunchAUT";
            this.buttonLaunchAUT.Size = new System.Drawing.Size(150, 25);
            this.buttonLaunchAUT.TabIndex = 0;
            this.buttonLaunchAUT.Text = "Launch in-process";
            this.buttonLaunchAUT.UseVisualStyleBackColor = true;
            this.buttonLaunchAUT.Click += new System.EventHandler(this.buttonLaunchAUT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Move main form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textTypes
            // 
            this.textTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textTypes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textTypes.Location = new System.Drawing.Point(12, 75);
            this.textTypes.Multiline = true;
            this.textTypes.Name = "textTypes";
            this.textTypes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textTypes.Size = new System.Drawing.Size(484, 342);
            this.textTypes.TabIndex = 2;
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(12, 12);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(399, 20);
            this.textPath.TabIndex = 3;
            this.textPath.Text = "..\\\\..\\\\..\\\\AppUnderTest\\\\bin\\\\Debug\\\\AppUnderTest.exe";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(417, 9);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(29, 25);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // frmTestHarness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 429);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.textTypes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLaunchAUT);
            this.Name = "frmTestHarness";
            this.Text = "Test harness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLaunchAUT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textTypes;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.Button buttonBrowse;
    }
}

