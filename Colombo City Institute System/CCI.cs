using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colombo_City_Institute_System
{
    public partial class CCI : Form
    {
        public CCI()
        {
            InitializeComponent();
        }

        

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CCI_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongTimeString();

            label7.Text = DateTime.Now.ToLongDateString();
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }

        

        private void circularButton1_Click(object sender, EventArgs e)
        {
            AboutBox1 obj = new AboutBox1();
            this.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
