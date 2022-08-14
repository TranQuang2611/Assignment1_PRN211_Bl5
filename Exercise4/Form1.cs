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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 100; i++)
            {
                await Task.Delay(50);
                loadLabel.Text = "Loading " + i + "%";
                progressBar.Value = i;              
            }
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
            this.Close();
        }

    }
}
