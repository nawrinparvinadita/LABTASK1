// frmDashboard.cs
//
// NOTE: This file only contains btnLogout_Click as described in the
// lab sheet. Keep the rest of your existing frmDashboard.cs as-is —
// just replace this one method (it currently closes the whole app
// and shows "Goodbye Sayan").

using System;
using System.Windows.Forms;

namespace Login_and_Register
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                new frmLogin().Show();
                this.Close();
            }
        }
    }
}
