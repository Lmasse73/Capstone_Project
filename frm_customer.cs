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
    public partial class frm_customer : Form
    {
        public frm_customer()
        {
            InitializeComponent();
            LoadCustomers();
        }
        /// <summary>
        /// Method to get the current stored list in Homeclass and placing it
        /// in custlist.  Uses the custlist to show in combobox.
        /// </summary>
        private void LoadCustomers()
        {
            cmbBox_CustList.Items.Clear();
            cmbBox_CustList.Text = "Select Customer";

            List<string> custList = HomeClass.GetCustomerList();

            foreach (string customer in custList)
            {
                string[] items = customer.Split(',');
                string eachClient = items[0] + " " + items[1] + " " + items[2] + " " + items[3];
                cmbBox_CustList.Items.Add(eachClient);
            }
        }

        /// <summary>
        /// Method to open AddCust Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addcust_Click(object sender, EventArgs e)
        {
            Form_AddCust addCustForm = new Form_AddCust();
            addCustForm.Show();
        }

        /// <summary>
        /// To reload the customer list to the combobox, after creating new customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_refresh_customer_list_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        /// <summary>
        /// Method button to get a selected customer and store the cust information 
        /// in the SET methods in the homeclass.  Will be used in the Add Services Form.
        /// Opens the Add Services Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Services_Click(object sender, EventArgs e)
        {
            if (cmbBox_CustList.SelectedIndex == -1)
            {
                MessageBox.Show("Select a client from the list");
            }
            else
            {
                string selectedCustomer = cmbBox_CustList.SelectedItem.ToString();
                string[] custItems = selectedCustomer.Split(' ');
                HomeClass.SetCustName(custItems[0], custItems[1]);
                HomeClass.SetCustMail(custItems[2]);
                HomeClass.SetCustId(custItems[3]);
                Form_AddServices addServicesFrm = new Form_AddServices();
                addServicesFrm.Show();
            }
        }

        /// <summary>
        /// Close the cust form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
