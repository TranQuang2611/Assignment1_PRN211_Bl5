using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            check();
        }

        private void check()
        {
            if (string.IsNullOrEmpty(nameBox.Text))
            {
                checkNameLabel.ForeColor = Color.Red;
            }
            else
            {
                checkNameLabel.ForeColor = Color.Blue;
            }
            if (string.IsNullOrEmpty(passBox.Text))
            {
                checkPassLabel.ForeColor = Color.Red;
            }
            else
            {
                checkPassLabel.ForeColor = Color.Blue;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            viButton.Text = "Việt";
            engButton.Text = "Anh";
            loginLabel.Text = "ĐĂNG NHẬP";
            nameLabel.Text = "Tên đăng nhập";
            passLabel.Text = "Mật khẩu";
            loginButton.Text = "ĐĂNG NHẬP";
            resetButton.Text = "LÀM MỚI";
            exitButton.Text = "THOÁT";
            forgetButton.Text = "Quên mật khẩu ?";
        }

        private void engButton_CheckedChanged(object sender, EventArgs e)
        {

            viButton.Text = "VI";
            engButton.Text = "EN";
            loginLabel.Text = "LOGIN";
            nameLabel.Text = "User name";
            passLabel.Text = "Password";
            loginButton.Text = "LOGIN";
            resetButton.Text = "RESET";
            exitButton.Text = "EXIT";
            forgetButton.Text = "Forget Password ?";
        }

        private void nameBox_CursorChanged(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void nameBox_MouseHover(object sender, EventArgs e)
        {
            nameBox.BackColor = Color.Pink;
        }

        private void nameBox_MouseLeave(object sender, EventArgs e)
        {
            nameBox.BackColor = Color.White;
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void passBox_MouseHover(object sender, EventArgs e)
        {
            passBox.BackColor = Color.Pink;
        }

        private void passBox_MouseLeave(object sender, EventArgs e)
        {
            passBox.BackColor = Color.White;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            passBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if ((nameBox.Text.Equals("Admin") || nameBox.Text.Equals("admin")) && passBox.Text.Equals("123456"))
            {             
                Pheptinh pheptinh = new Pheptinh();
                pheptinh.ShowDialog();
                this.Close();
            }
        }
    }
}
