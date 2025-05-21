using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TIC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Activity 2: "Hello, Windows Forms!"

        private void clickMe_Click(object sender, EventArgs e)
        {
            //var result = MessageBox.Show("Hello, World!", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

            //label1.Text = result.ToString();

            //label1.Text = result == DialogResult.Retry ? "Retry" : "Cancel";

            //label1.Text = "" + result.ToString() + " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + Environment.NewLine;

            //label1.Text += "Hello, World!" + Environment.NewLine;

            //if (result == DialogResult.Yes) {
            //    label1.Text = "Yes";
            //} else if (result == DialogResult.No) {
            //    label1.Text = "No";
            //} else if (result == DialogResult.Cancel) {
            //    label1.Text = "Cancel";
            //} else if (result == DialogResult.Retry) {
            //    label1.Text = "Retry";
            //} else if (result == DialogResult.Ignore) {
            //    label1.Text = "Ignore";
            //} else if (result == DialogResult.Abort) {
            //    label1.Text = "Abort";
            //} else if (result == DialogResult.None) {
            //    label1.Text = "None";
            //}


            //label1.Text = "Hello World!\n Click me to start";

            label1.ForeColor = Color.Blue;




        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Click again button";
        }


        //Activity 5: Windows Forms Input and Output
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "You typed: " + textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



    }
}
