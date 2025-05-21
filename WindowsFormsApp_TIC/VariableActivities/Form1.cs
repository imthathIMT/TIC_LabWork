using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableActivities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(this, null); // Call the load method to initialize labels
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Declare variables
            int clickCounter = 0;
            string statusMessage = "Application Started";

            lblIntegerDisplay.Text = clickCounter.ToString();  // Converts int to string
            lblStringDisplay.Text = statusMessage;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Read user input
            string input1 = txtNum1.Text;
            string input2 = txtNum2.Text;

            // Try parsing inputs to double
            bool isValid1 = double.TryParse(input1, out double num1);
            bool isValid2 = double.TryParse(input2, out double num2);

            if (isValid1 && isValid2)
            {
                double sum = num1 + num2;
                lblSumResult.Text = "Sum: " + sum.ToString();
            }
            else
            {
                lblSumResult.Text = "Invalid input";
            }
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            lblStringOutput.Text = txtInputString.Text.ToUpper();

        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            lblStringOutput.Text = txtInputString.Text.ToLower();

        }


        private void btnProcessString_Click(object sender, EventArgs e)
        {
            string sentence = txtSentence.Text;

            // Display string length
            lblLength.Text = "Length: " + sentence.Length;

            // Check if string has at least 5 characters before calling Substring
            if (sentence.Length >= 5)
            {
                lblSubstring.Text = "First 5: " + sentence.Substring(0, 5);
            }
            else
            {
                lblSubstring.Text = "Too short";
            }
        }
    }
}
