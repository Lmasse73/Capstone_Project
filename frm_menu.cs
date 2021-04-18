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

        /// <summary>
        /// Quit button, opens form quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_quit_Click(object sender, EventArgs e)
        {
            HomeClass.WriteListsToFile();
            Form_Quit quitfrm = new Form_Quit();
            quitfrm.Show();
        }
        /// <summary>
        /// Customer Button, customer form opens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cust_Click(object sender, EventArgs e)
        {
            frm_customer custForm = new frm_customer();
            custForm.Show();
        }
    }
}
