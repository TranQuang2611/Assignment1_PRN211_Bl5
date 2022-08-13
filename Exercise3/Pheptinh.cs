using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Pheptinh : Form
    {
        public Pheptinh()
        {
            InitializeComponent();
            check();
        }

        private void check()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                checkEnterA.ForeColor = Color.Red;
            }
            else
            {
                checkEnterA.ForeColor = Color.Blue;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                checkEnterB.ForeColor = Color.Red;
            }
            else
            {
                checkEnterB.ForeColor = Color.Blue;
            }
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Pink;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {

            textBox1.BackColor = Color.White;
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Pink;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void Pheptinh_Load(object sender, EventArgs e)
        {
            caculateBox.SelectedIndex = 0;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            resultBox.Text = "";
        }

        private void doButton_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                if(caculateBox.SelectedIndex == 0)
                {
                    resultBox.Text = (a + b).ToString();
                }
                if (caculateBox.SelectedIndex == 1)
                {
                    resultBox.Text = (a - b).ToString();
                }
                if (caculateBox.SelectedIndex == 2)
                {
                    resultBox.Text = (a * b).ToString();
                }
                if (caculateBox.SelectedIndex == 3)
                {
                    resultBox.Text = ((float)a / b).ToString();
                }             
            }
            catch (Exception)
            {
                MessageBox.Show("Nhap du lieu sai !!!");
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to go to the next article ?", "Thông báo", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                Tuychon tuychon = new Tuychon();
                tuychon.ShowDialog();
                this.Close();
            }
        }
    }
}
