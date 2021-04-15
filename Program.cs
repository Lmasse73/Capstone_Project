using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project
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
            HomeClass.SetCustomerList();
            HomeClass.SetIdList();
            HomeClass.SetCustomerServicesList();
            HomeClass.InitializeServiceAndCost();
            Application.Run(new frm_welcome());
        }
    }
}
