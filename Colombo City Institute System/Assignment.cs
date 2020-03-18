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
    public partial class Assignment : Form
    {
        SqlConnection sqlCon;
        SqlDataAdapter sda;
        DataTable dt;
        public Assignment()
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                {
                    SqlCommand cmd = new SqlCommand("insert into AssignmentInfo values('" + txtStudentID.Text + "','" + txtAssignmentID.Text+ "','" + cmbSubjectName.Text + "','" + cmbGrade.Text + "','" + cmbStatus.Text + "');", sqlCon);


                    int temp = cmd.ExecuteNonQuery();

                    if (temp > 0)
                    {
                        MessageBox.Show("Record Successfuly Added", "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record Fail to Added", "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MISHAL\\MISHSQL;Initial Catalog=Mish;Integrated Security=True");
            sda = new SqlDataAdapter("select SID,Sname,Grade,Status,AID from AssignmentInfo where StudentID='" + txtStudentID.Text + "'", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from AssignmentInfo where StudentID = '" + txtStudentID.Text + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                    txtAssignmentID.Text = dr[1].ToString();
                    cmbSubjectName.Text = dr[2].ToString();
                    cmbGrade.Text = dr[3].ToString();
                    cmbStatus.Text = dr[4].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Data Not Recorded!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Searching Data " + ex, "Coordinator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
