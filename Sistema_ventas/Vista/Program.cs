using System;
using System.Windows.Forms;

namespace Vista
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
               Application.Run(new Principal(login.Usuario));
            }
        }
    }
}
