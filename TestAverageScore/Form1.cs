using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAverageScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcAvg_Click(object sender, EventArgs e)
        {
            try
            {
                double test1, test2, test3, average;

                test1 = double.Parse(Test1Box.Text);
                test2 = double.Parse(Test2Box.Text);
                test3 = double.Parse(Test3Box.Text);

                average = (test1 + test2 + test3) / 3.0;

                AverageBox.Text = average.ToString("n1");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Test1Box.Text = "";
            Test2Box.Text = "";
            Test3Box.Text = "";
            AverageBox.Text = "";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
