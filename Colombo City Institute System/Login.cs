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
    public partial class Login : Form
    {
        SqlConnection sqlCon;
        public Login()
        {
            try
            {

                DBConnectionClass obj = new DBConnectionClass();
                sqlCon = obj.GetConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting" + ex, "Customer Form", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {

                bool valid = true;
                if (string.IsNullOrEmpty(txtUserId.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Need to fill all the values ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
                if (valid)
                {
                    String UserType = null;
                    SqlCommand cmd = new SqlCommand
                    ("Select UserType from  UserInfo where UserID ='" + txtUserId.Text + "' and Password ='" + txtPassword.Text + "' ", sqlCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    Boolean records = dr.HasRows;
                    if (records)
                    {
                        while (dr.Read())
                        {
                            UserType = dr[0].ToString();
                        }
                        if (UserType.Equals("Admin"))
                        {
                            Admin obj = new Admin();
                            obj.Show();
                            this.Hide();
                        }
                        else if (UserType.Equals("Student"))
                        {
                            student obj = new student();
                            obj.Show();
                            this.Hide();
                        }
                        else if (UserType.Equals("Coordinator"))
                        {
                            Form1 obj = new Form1();
                            obj.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid login Credentials", "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Login Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

