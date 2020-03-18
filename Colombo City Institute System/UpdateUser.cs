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
    public partial class UpdateUser : Form
    {
        SqlConnection sqlCon;
        SqlDataAdapter sda;
        DataTable dt;
        public UpdateUser()
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Update UserInfo set Password = '" + txtPassword.Text + "', UserType='" + cmbUserType.Text + "'from UserInfo where UserID='" + txtUserId.Text + "'", sqlCon);

                int numberOfRecords = cmd.ExecuteNonQuery();
                if (numberOfRecords > 0)
                {
                    MessageBox.Show("RECORDS SUCCESSFULLY UPDATED!", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR UPDATING DATA" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
