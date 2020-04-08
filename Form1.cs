using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
        


            
            
            int oceanCount = 5;
            string oceanInfo = $"There are {oceanCount} oceans on earth.";
            //"There are 5 oceans on earth."

            string ocean = "Pacific Ocean";
            double oceanSize = 63800000;
            string oceanSizeUnits = "square miles";

            string pacificInfo = $"The {ocean} is {oceanSize} {oceanSizeUnits}.";
            // "The Pacific Ocean is 63,800,000 square miles."
            
            string answer = txtAnswer.Text;
            answer = answer.ToLower();
            
            if (answer.Contains("pacific"))
            {
                MessageBox.Show("Correct!", "Result");
            }
            else
            {
                MessageBox.Show("Incorrect, the answer is the Pacific Ocean", "Result");
            }
        }
    }
}
