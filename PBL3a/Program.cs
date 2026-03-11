using System;
using System.Windows.Forms;
using PBL3a.UI.Login;
using PBL3a.UI.Student;

namespace PBL3a
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LoginForm());
        }
    }
}