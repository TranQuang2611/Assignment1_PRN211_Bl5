using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Lunar : Form
    {
        public Lunar()
        {
            InitializeComponent();
        }

        string[] chiCheck = { "Thân", "Dậu", "Tuất", "Hợi", "Tí", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };
        string[] canCheck = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ"};

        private void viewButton_Click(object sender, EventArgs e)
        {
            try
            {
                int chi = Convert.ToInt32(textBox1.Text)%12;
                int can = Convert.ToInt32(textBox1.Text)%10;
                textBox2.Text = canCheck[can] + " " + chiCheck[chi];
            }catch (Exception ex)
            {
                MessageBox.Show("Vui long nhap dung nam");
            }
        }

        private void exitButoon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
