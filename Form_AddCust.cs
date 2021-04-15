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
    public partial class Form_AddCust : Form
    {
        public Form_AddCust()
        {
            InitializeComponent();
        }

        private void btn_savecust_Click(object sender, EventArgs e)
        {
            string nextCustomerId = HomeClass.GetNextCustomerID();
            string customer = txtbox_first.Text + "," + txtbox_last.Text + "," + txtbox_email.Text + "," + nextCustomerId;
            HomeClass.CustList.Add(customer);
            MessageBox.Show("Customer Info Saved, Add Another Client or Go Back");
            txtbox_first.Clear();
            txtbox_last.Clear();
            txtbox_email.Clear();
            txtbox_first.Focus();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AddCust_Load(object sender, EventArgs e)
        {

        }
    }
}
