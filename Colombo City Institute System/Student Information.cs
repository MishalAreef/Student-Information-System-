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

    public partial class Student_Information : Form
    {
        SqlConnection sqlCon;
        SqlDataAdapter sda;
        DataTable dt;
        public Student_Information()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=10.0.0.4;initial catalog=Mish;user id-hnd; password=hnd");
            sda = new SqlDataAdapter("select StudentID,StudentFullName,DateofBirth,NIC,Telephone,Email,Address,ProgramName,BatchID,BatchName from Student Information", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                {
                    SqlCommand cmd = new SqlCommand("insert into StudentInfo values('" + txtStudentID.Text + "','" + txtFullName.Text + "','" + DOB.Text + "','" + cmbGender.Text + "','" + txtNICNumber.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + cmbProgramName.Text + "','" + cmbBatchName.Text + "','" + cmbSubjectName.Text + "');", sqlCon);


                    int temp = cmd.ExecuteNonQuery();

                    if (temp > 0)
                    {
                        MessageBox.Show("Record Successfuly Added", "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record Fail to Add", "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtFullName.Text = "";
            txtMobile.Text = "";
            txtNICNumber.Text = "";
            cmbBatchName.Text = "";
            cmbGender.Text = "";
            cmbProgramName.Text = "";
            cmbSubjectName.Text = "";
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from StudentInfo where StudentID = '" + txtStudentID.Text + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtFullName.Text = dr[1].ToString();
                    DOB.Text = dr[2].ToString();
                    cmbGender.Text = dr[3].ToString();
                    txtNICNumber.Text = dr[4].ToString();
                    txtAddress.Text = dr[5].ToString();
                    txtMobile.Text = dr[6].ToString();
                    cmbProgramName.Text = dr[7].ToString();
                    cmbProgramName.Text = dr[8].ToString();
                    cmbBatchName.Text = dr[9].ToString();
                }
                else
                {
                    MessageBox.Show("Data Not Found!", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Searching Data" + ex, "Coordinator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=10.0.0.4;Initial Catalog=mish;User Id=hnd; Password=hnd");
            sda = new SqlDataAdapter("select StudentID,Name,Date,Gender,NICNumber,Mobile,Email,Address,ProgramName,BatchNumber,SubjectName from StudentInfo", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

