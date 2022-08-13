using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Random : Form
    {
        public Random()
        {
            InitializeComponent();
        }

        List<int> list = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(number.Text);
            if (list.Count == total)
            {
                MessageBox.Show("Đã hết số để chọn", "Thông báo");
            }
            System.Random random = new();
            int randomNumber = random.Next(1, total + 1);
            if (!list.Contains(randomNumber))
            {
                list.Add(randomNumber);
            }
            else
            {
                while (list.Contains(randomNumber))
                {
                    randomNumber = random.Next(1, total + 1);
                }
                list.Add(randomNumber);
            }
            resultLabel.Text = randomNumber.ToString();
            //while (list.Count() < total)
            //{            
            //    int randomNumber = random.Next(1, total + 1);
            //    if (list.Contains(randomNumber))
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        list.Add(randomNumber);
            //        resultLabel.Text = randomNumber.ToString();                  
            //        break;
            //    }
            //}

        }
    }
}
