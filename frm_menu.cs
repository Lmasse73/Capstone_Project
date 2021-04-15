using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Project
{
    public partial class frm_menu : Form
    {
        public string AppSelection;
        public frm_menu()
        {
            InitializeComponent();
        }

        private void rdbtn_customer_CheckedChanged(object sender, EventArgs e)
        {
            HomeClass.SetUserSelect("customer");

        }

        private void rdbtn_services_CheckedChanged(object sender, EventArgs e)
        {
            HomeClass.SetUserSelect("services");

        }


        private void btn_quit_Click(object sender, EventArgs e)
        {
            HomeClass.WriteListsToFile();
            Form_Quit quitfrm = new Form_Quit();
            quitfrm.Show();
        }

        private void Btn_Cust_Click(object sender, EventArgs e)
        {
            frm_customer custForm = new frm_customer();
            custForm.Show();
        }
    }
}
