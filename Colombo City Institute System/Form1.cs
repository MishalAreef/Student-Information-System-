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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            Student_Information obj = new Student_Information();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CCI obj = new CCI();
            obj.Show();
            this.Close();
        }

        private void btnAddBatchSubject_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStudentInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUsers_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStudentInformation_Click(object sender, EventArgs e)
        {
            Student_Information obj = new Student_Information();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Assignment obj = new Assignment();
            obj.Show();
        }
    }
}
