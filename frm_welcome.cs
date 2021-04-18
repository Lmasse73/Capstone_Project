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
    public partial class frm_welcome : Form
    {
        public frm_welcome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method to open the menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_open_Click(object sender, EventArgs e)
        {
            frm_menu menufrm = new frm_menu();
            menufrm.Show();
        }
    }
}
