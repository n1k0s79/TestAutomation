using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AppUnderTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.UpdatePossibleCombinations();
            this.UpdatePossiblePermutations();
            this.UpdateMthCombination();
            this.UpdateMthPermutation();
        }

        private void buttonGenerateAll_Click(object sender, EventArgs e)
        {
            var all = Math.Combination<string>.GetAllPossible(GetItems(CombinationItems), SubsetCount);
            textBox1.Text = ListToString(all);
        }

        private string ListToString<T>(List<T> items)
        {
            var b = new System.Text.StringBuilder();

            b.AppendLine("Total: " + items.Count);
            b.AppendLine("------------------------------");

            for (int i = 0; i < items.Count; i++)
            {
                b.AppendLine(string.Format("{0}. {1}", (i + 1).ToString(), items[i].ToString()));
            }

            return b.ToString();
        }

        private string[] GetItems(int n)
        {
            var ret = new List<string>();
            for(int i = 0; i< n; i++)
            {
                ret.Add(i.ToString());
            }

            return ret.ToArray();
        }

        private void nmCombinationItems_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePossibleCombinations();            
        }

        private void nmSubset_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePossibleCombinations();
        }

        private void UpdatePossibleCombinations()
        {
            long max = Math.Combination.GetNumberOfAllPossible(CombinationItems, SubsetCount);
            textPossibleCombinations.Text = max.ToString();
            nmMthCombination.Maximum = max - 1;
        }

        private int CombinationM
        {
            get
            {
                return (int)nmMthCombination.Value;
            }
        }

        private int PermutationM
        {
            get
            {
                return (int)nmMthPermutation.Value;
            }
        }

        private void UpdateMthCombination()
        {
            var c = new Math.Combination<string>(GetItems(PermutationItems), SubsetCount);
            var mth = c.GetMth(CombinationM);
            textMthCombination.Text = mth.ToString();
        }

        private void UpdateMthPermutation()
        {
            var mth = new Math.Permutation<string>(GetItems(PermutationItems), PermutationM);
            textMthPermutation.Text = mth.ToString();
        }

        private int CombinationItems
        {
            get
            {
                return (int)this.nmCombinationItems.Value;
            }
        }

        private int PermutationItems
        {
            get
            {
                return (int)this.nmPermutationItems.Value;
            }
        }

        private int SubsetCount
        {
            get
            {
                return (int)this.nmSubset.Value;
            }
        }

        private void radioPermutations_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePossibleCombinations();
        }

        private void radioCombinations_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePossibleCombinations();
        }

        private void buttonGenerateAllPermutations_Click(object sender, EventArgs e)
        {
            var all = Math.Permutation<string>.GetAllPossible(GetItems(PermutationItems));
            textBox1.Text = ListToString(all);
        }

        private void nmPermutationItems_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePossiblePermutations();
        }

        private void UpdatePossiblePermutations()
        {
            textPossiblePermutations.Text = Math.Permutation.GetNumberOfAllPossible((int)nmPermutationItems.Value).ToString();
        }

        private void nmMthCombination_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateMthCombination();
        }

        private void nmMthPermutation_ValueChanged(object sender, EventArgs e)
        {
            this.UpdateMthPermutation();
        }
    }
}