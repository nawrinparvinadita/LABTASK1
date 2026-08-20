// Program.cs
//
// NOTE: Only the Application.Run(...) line needs to change — it
// currently starts on frmRegister. Change it to frmLogin so the app
// opens on the login screen like a real application.

using System;
using System.Windows.Forms;

namespace Login_and_Register
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
