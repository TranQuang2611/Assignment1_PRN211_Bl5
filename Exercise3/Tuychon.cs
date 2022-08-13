using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Tuychon : Form
    {
        public Tuychon()
        {
            InitializeComponent();
        }

        private void aBox_MouseHover(object sender, EventArgs e)
        {
            aBox.BackColor = Color.Pink;
        }

        private void aBox_MouseLeave(object sender, EventArgs e)
        {
            aBox.BackColor = Color.White;
        }

        private void bBox_MouseHover(object sender, EventArgs e)
        {
            bBox.BackColor = Color.Pink;
        }

        private void bBox_MouseLeave(object sender, EventArgs e)
        {
            bBox.BackColor = Color.White;
        }
       
        private void aBox_TextChanged(object sender, EventArgs e)
        {         
            Regex regex = new Regex("^[-+]?\\d*$");
            if (!regex.IsMatch(aBox.Text))
            {
                aBox.Text = "";
            }
            
        }

        private void bBox_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[-+]?\\d*$");
            if (!regex.IsMatch(bBox.Text))
            {
                bBox.Text = "";
            }
        }

        private int UCLN(int a, int b)
        {
            while (a * b != 0)
            {
                if (a > b)
                {
                    a %= b; // a = a % b
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(aBox.Text) && !string.IsNullOrEmpty(bBox.Text))
            {
                int a = Convert.ToInt32(aBox.Text);
                int b = Convert.ToInt32(bBox.Text);
                if (option1Button.Checked)
                {
                    if(a == 0)
                    {
                        if(b == 0)
                        {
                            resultLabel.Text = "Phương trình vô số nghiệm";
                        }
                        else
                        {
                            resultLabel.Text = "Phương trình vô nghiệm";
                        }
                    }
                    else
                    {
                        resultLabel.Text = ((float)(-b)/a).ToString();
                    }
                }
                if (option2Button.Checked)
                {
                   
                    resultLabel.Text = UCLN(a, b).ToString(); 
                }
                if (option3Button.Checked)
                {
                    resultLabel.Text = ((a*b)/UCLN(a,b)).ToString();
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            aBox.Text = "";
            bBox.Text = "";
            resultLabel.Text = "";
        }
    }
}
