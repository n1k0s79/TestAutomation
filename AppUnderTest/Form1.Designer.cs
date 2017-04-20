namespace AppUnderTest
{
    partial class Form1
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
            this.buttonGenerateAllCombinations = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nmCombinationItems = new System.Windows.Forms.NumericUpDown();
            this.nmSubset = new System.Windows.Forms.NumericUpDown();
            this.labelTotal = new System.Windows.Forms.Label();
            this.nmMthCombination = new System.Windows.Forms.NumericUpDown();
            this.groupCombinations = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textMthCombination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textMthPermutation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmPermutationItems = new System.Windows.Forms.NumericUpDown();
            this.buttonGenerateAllPermutations = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nmMthPermutation = new System.Windows.Forms.NumericUpDown();
            this.textPossibleCombinations = new System.Windows.Forms.TextBox();
            this.textPossiblePermutations = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmCombinationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSubset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMthCombination)).BeginInit();
            this.groupCombinations.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPermutationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMthPermutation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateAllCombinations
            // 
            this.buttonGenerateAllCombinations.Location = new System.Drawing.Point(92, 107);
            this.buttonGenerateAllCombinations.Name = "buttonGenerateAllCombinations";
            this.buttonGenerateAllCombinations.Size = new System.Drawing.Size(100, 25);
            this.buttonGenerateAllCombinations.TabIndex = 0;
            this.buttonGenerateAllCombinations.Text = "Generate all";
            this.buttonGenerateAllCombinations.UseVisualStyleBackColor = true;
            this.buttonGenerateAllCombinations.Click += new System.EventHandler(this.buttonGenerateAll_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(233, 20);
            this.textBox1.MaxLength = 0;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(448, 478);
            this.textBox1.TabIndex = 1;
            // 
            // nmCombinationItems
            // 
            this.nmCombinationItems.Location = new System.Drawing.Point(127, 29);
            this.nmCombinationItems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCombinationItems.Name = "nmCombinationItems";
            this.nmCombinationItems.Size = new System.Drawing.Size(65, 20);
            this.nmCombinationItems.TabIndex = 2;
            this.nmCombinationItems.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmCombinationItems.ValueChanged += new System.EventHandler(this.nmCombinationItems_ValueChanged);
            // 
            // nmSubset
            // 
            this.nmSubset.Location = new System.Drawing.Point(127, 55);
            this.nmSubset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmSubset.Name = "nmSubset";
            this.nmSubset.Size = new System.Drawing.Size(65, 20);
            this.nmSubset.TabIndex = 3;
            this.nmSubset.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmSubset.ValueChanged += new System.EventHandler(this.nmSubset_ValueChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(16, 83);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(99, 13);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total combinations:";
            // 
            // nmMthCombination
            // 
            this.nmMthCombination.Location = new System.Drawing.Point(127, 143);
            this.nmMthCombination.Name = "nmMthCombination";
            this.nmMthCombination.Size = new System.Drawing.Size(65, 20);
            this.nmMthCombination.TabIndex = 5;
            this.nmMthCombination.ValueChanged += new System.EventHandler(this.nmMthCombination_ValueChanged);
            // 
            // groupCombinations
            // 
            this.groupCombinations.Controls.Add(this.textPossibleCombinations);
            this.groupCombinations.Controls.Add(this.label3);
            this.groupCombinations.Controls.Add(this.textMthCombination);
            this.groupCombinations.Controls.Add(this.nmMthCombination);
            this.groupCombinations.Controls.Add(this.label2);
            this.groupCombinations.Controls.Add(this.label1);
            this.groupCombinations.Controls.Add(this.nmCombinationItems);
            this.groupCombinations.Controls.Add(this.buttonGenerateAllCombinations);
            this.groupCombinations.Controls.Add(this.nmSubset);
            this.groupCombinations.Controls.Add(this.labelTotal);
            this.groupCombinations.Location = new System.Drawing.Point(12, 12);
            this.groupCombinations.Name = "groupCombinations";
            this.groupCombinations.Size = new System.Drawing.Size(215, 236);
            this.groupCombinations.TabIndex = 9;
            this.groupCombinations.TabStop = false;
            this.groupCombinations.Text = "Combinations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mth item:";
            // 
            // textMthCombination
            // 
            this.textMthCombination.Location = new System.Drawing.Point(19, 175);
            this.textMthCombination.Multiline = true;
            this.textMthCombination.Name = "textMthCombination";
            this.textMthCombination.ReadOnly = true;
            this.textMthCombination.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMthCombination.Size = new System.Drawing.Size(173, 44);
            this.textMthCombination.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Choose:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of items:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textPossiblePermutations);
            this.groupBox1.Controls.Add(this.textMthPermutation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nmPermutationItems);
            this.groupBox1.Controls.Add(this.buttonGenerateAllPermutations);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nmMthPermutation);
            this.groupBox1.Location = new System.Drawing.Point(12, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 236);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permutations";
            // 
            // textMthPermutation
            // 
            this.textMthPermutation.Location = new System.Drawing.Point(19, 140);
            this.textMthPermutation.Multiline = true;
            this.textMthPermutation.Name = "textMthPermutation";
            this.textMthPermutation.ReadOnly = true;
            this.textMthPermutation.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textMthPermutation.Size = new System.Drawing.Size(173, 44);
            this.textMthPermutation.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mth item:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Number of items:";
            // 
            // nmPermutationItems
            // 
            this.nmPermutationItems.Location = new System.Drawing.Point(127, 29);
            this.nmPermutationItems.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmPermutationItems.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPermutationItems.Name = "nmPermutationItems";
            this.nmPermutationItems.Size = new System.Drawing.Size(65, 20);
            this.nmPermutationItems.TabIndex = 2;
            this.nmPermutationItems.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmPermutationItems.ValueChanged += new System.EventHandler(this.nmPermutationItems_ValueChanged);
            // 
            // buttonGenerateAllPermutations
            // 
            this.buttonGenerateAllPermutations.Location = new System.Drawing.Point(92, 81);
            this.buttonGenerateAllPermutations.Name = "buttonGenerateAllPermutations";
            this.buttonGenerateAllPermutations.Size = new System.Drawing.Size(100, 25);
            this.buttonGenerateAllPermutations.TabIndex = 0;
            this.buttonGenerateAllPermutations.Text = "Generate all";
            this.buttonGenerateAllPermutations.UseVisualStyleBackColor = true;
            this.buttonGenerateAllPermutations.Click += new System.EventHandler(this.buttonGenerateAllPermutations_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total permutations:";
            // 
            // nmMthPermutation
            // 
            this.nmMthPermutation.Location = new System.Drawing.Point(127, 114);
            this.nmMthPermutation.Name = "nmMthPermutation";
            this.nmMthPermutation.Size = new System.Drawing.Size(65, 20);
            this.nmMthPermutation.TabIndex = 5;
            this.nmMthPermutation.ValueChanged += new System.EventHandler(this.nmMthPermutation_ValueChanged);
            // 
            // textPossibleCombinations
            // 
            this.textPossibleCombinations.Location = new System.Drawing.Point(127, 81);
            this.textPossibleCombinations.Name = "textPossibleCombinations";
            this.textPossibleCombinations.ReadOnly = true;
            this.textPossibleCombinations.Size = new System.Drawing.Size(65, 20);
            this.textPossibleCombinations.TabIndex = 12;
            // 
            // textPossiblePermutations
            // 
            this.textPossiblePermutations.Location = new System.Drawing.Point(127, 55);
            this.textPossiblePermutations.Name = "textPossiblePermutations";
            this.textPossiblePermutations.ReadOnly = true;
            this.textPossiblePermutations.Size = new System.Drawing.Size(65, 20);
            this.textPossiblePermutations.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 510);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupCombinations);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmCombinationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSubset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMthCombination)).EndInit();
            this.groupCombinations.ResumeLayout(false);
            this.groupCombinations.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPermutationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMthPermutation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerateAllCombinations;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown nmCombinationItems;
        private System.Windows.Forms.NumericUpDown nmSubset;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.NumericUpDown nmMthCombination;
        private System.Windows.Forms.GroupBox groupCombinations;
        private System.Windows.Forms.TextBox textMthCombination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textMthPermutation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmPermutationItems;
        private System.Windows.Forms.Button buttonGenerateAllPermutations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmMthPermutation;
        private System.Windows.Forms.TextBox textPossibleCombinations;
        private System.Windows.Forms.TextBox textPossiblePermutations;
    }
}

