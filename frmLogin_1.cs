// frmLogin.cs
//
// NOTE: This file only contains the parts described in the lab sheet
// (usings, the connection string field, and btnLogin_Click).
// Keep the rest of your existing frmLogin.cs (class declaration,
// constructor, designer-generated InitializeComponent call, and any
// other event handlers like show-password / Clear / Close) exactly as
// they are in the downloaded project — just make these three edits.

using System;
using System.Windows.Forms;
using System.Data.SqlClient;   // <-- replaces: using System.Data.OleDb;
using System.Configuration;

namespace Login_and_Register
{
    public partial class frmLogin : Form
    {
        // Replaces the three OleDb lines (OleDbConnection / OleDbCommand / OleDbDataAdapter)
        private static string myConn =
            ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(myConn))
                {
                    con.Open();

                    string login = "SELECT COUNT(*) FROM tbl_users WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(login, con))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            new frmDashboard().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password, please try again.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Text = "";
                            txtPassword.Text = "";
                            txtUsername.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error:\n\n" + ex.Message);
            }
        }
    }
}
