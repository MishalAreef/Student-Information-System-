using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Colombo_City_Institute_System
{
    public partial class Profile : Form
    {
        SqlConnection sqlCon;
        SqlDataAdapter sda;
        DataTable dt;
        public Profile()
        {
            try
            {

                DBConnectionClass obj = new DBConnectionClass();
                sqlCon = obj.GetConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting" + ex, "Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student obj = new student();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.0.0.4;Initial Catalog=mish;User Id=hnd; Password=hnd");
            sda = new SqlDataAdapter("select StudentID,Name,Date,Gender,NICNumber,Mobile,Email,Address,ProgramName,BatchNumber,SubjectName from StudentInfo", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            student obj = new student();
            obj.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.0.0.4;Initial Catalog=mish;User Id=hnd; Password=hnd");
            sda = new SqlDataAdapter("select StudentID,Name,Date,Gender,NICNumber,Mobile,Email,Address,ProgramName,BatchNumber,SubjectName from StudentInfo where StudentID='" + txtStudentID.Text + "'", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnViewAR_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.0.0.4;Initial Catalog=mish;User Id=hnd; Password=hnd");
            sda = new SqlDataAdapter("select StudentID,AssignmentID,Grade,Status from AssignmentInfo", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
