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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CCI obj = new CCI();
            obj.Show();
            this.Close();
        }

        

        private void btnInformation_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.Show();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
