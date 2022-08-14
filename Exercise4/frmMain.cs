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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void arsenal_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"E:\Summer FPT 2022\Assignment1\Exercise4\Img\arsenal.jpg";         
        }

        private void real_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"E:\Summer FPT 2022\Assignment1\Exercise4\Img\real.png";
        }

        private void mu_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"E:\Summer FPT 2022\Assignment1\Exercise4\Img\mu.png";
        }


        private void barcelona_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"E:\Summer FPT 2022\Assignment1\Exercise4\Img\barca.png";
        }

        private void juve_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"E:\Summer FPT 2022\Assignment1\Exercise4\Img\juve.png";
        }

        private void psg_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"E:\Summer FPT 2022\Assignment1\Exercise4\Img\psg.png";
        }

        private void bayern_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"E:\Summer FPT 2022\Assignment1\Exercise4\Img\bayern.png";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lunarButton_Click(object sender, EventArgs e)
        {
            Lunar lunar = new Lunar();
            lunar.ShowDialog();
            this.Close();
        }
    }
}
