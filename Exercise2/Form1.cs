using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codeBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codeBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            codeBox.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            codeBox.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            codeBox.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            codeBox.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            codeBox.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            codeBox.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            codeBox.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            codeBox.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            codeBox.Text = "";
        }
    }
}
