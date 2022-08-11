using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng", "Thông báo");
            }
            else
            {
                if (chkClean.Checked)
                {
                    total += 100000;
                }
                if (chkWhitening.Checked)
                {
                    total += 1200000;
                }
                if (chkXRay.Checked)
                {
                    total += 200000;
                }
                total += Convert.ToInt32(numFilling.Value)*80000;
            }
            txtTotal.Text = "$" + total.ToString();
        }
    }
}
