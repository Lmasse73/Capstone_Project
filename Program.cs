using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project
{
    static class Program
    {
        /***********************************
         Title: Client Tracking Application
        Application Type: Winform
        Description: Application creates/tracks 
            clients and services and payments made.
            Tracks total due.
        Author: Laurent Masse
        Date Created: 4/11/2021
        Last Modified: 4/18/2021
        ***********************************/
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*Run the methods to read the customer, customerID, and service files. (Capstone folder)
             Loads/stores the information from files to the appropriate lists.
            Lists in HomeClass are accessed by all the forms in the app.*/
            HomeClass.SetCustomerList();
            HomeClass.SetIdList();
            HomeClass.SetCustomerServicesList();

            /*Create and load a dictionary that has the service enums and costs.
             Is accessible by the forms in the app.*/
            HomeClass.InitializeServiceAndCost();
            Application.Run(new frm_welcome());
        }
    }
}
