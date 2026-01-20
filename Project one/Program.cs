using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_one
{
    internal static class Program
    {
        //Arghya 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new Admin_Login());
             //Application.Run(new User_login_page());
            //Application.Run(new Volunteer_Dashboard());
        }
    }
}
