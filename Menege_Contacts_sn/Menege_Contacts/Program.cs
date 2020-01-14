using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Menege_Contacts
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Menege_Contacts.NewFolder1.Login_Register_Form());

            Menege_Contacts.NewFolder1.Login_Register_Form rf = new Menege_Contacts.NewFolder1.Login_Register_Form();
            if (rf.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
