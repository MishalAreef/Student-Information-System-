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
    public partial class Register : Form
    {
        SqlConnection sqlCon;
        public Register()
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

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                bool valid = true;
                if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text) || string.IsNullOrEmpty(cmbUserType.Text))
                {
                    MessageBox.Show("Please fill all the information! ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
                else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Password and confirm password should match ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valid = false;
                }
                if (valid)
                {
                    SqlCommand cmd = new SqlCommand("insert into UserInfo values('" + txtUserId.Text + "', '" + txtPassword.Text + "','" + cmbUserType.Text + "');", sqlCon);


                    int temp = cmd.ExecuteNonQuery();

                    if (temp > 0)
                    {
                        MessageBox.Show("User Successfully Registered!", "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to Register User!PLEASE TRY AGAIN! ", "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data" + ex, "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select UserName from  UserInfo", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                Boolean records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    string idString = id.Substring(1);
                    int CTR = Int32.Parse(idString);
                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;
                        txtUserId.Text = "+960" + CTR;
                    }
                    else if (CTR >= 9 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        txtUserId.Text = "+96" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        txtUserId.Text = "+" + CTR;
                    }

                }

                else
                {
                    txtUserId.Text = "+960";
                }
                dr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("error" + e1, "Register Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Register_Load_1(object sender, EventArgs e)
        {

        }
    }
}
