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
    public partial class Form_AddServices : Form
    {
        public Form_AddServices()
        {
            InitializeComponent();
            InitializeAddServiceForm();
        }

        /// <summary>
        /// Method to populate the text box with selected cust info.
        /// </summary>
        private void InitializeAddServiceForm()
        {
            txtBox_CustId.Text = "Cust ID " + HomeClass.GetCustId();
            string custID = HomeClass.GetCustId();
            txtBox_CustName.Text = HomeClass.GetCustName();

            double total = 0;
            double amount;

            //headers
            listView_ServiceList.View = View.Details;
            listView_ServiceList.Columns.Add("Date", 100);
            listView_ServiceList.Columns.Add("Service", 100);
            listView_ServiceList.Columns.Add("Cost", -2);

            //go through the customer service list, write info based on customerID selected
            foreach (string transaction in HomeClass.CustomerServicesList)
            {
                string[] transactionItems = transaction.Split(',');

                //match the custID from selected customer with ID from the list 
                if (transactionItems[0] == custID)
                {
                    string transactionDate = transactionItems[1].ToString();
                    string transactionType = transactionItems[2].ToString();
                    string cost = transactionItems[3].ToString();

                    //totaling the amount due
                    double.TryParse(cost, out amount);
                    total = total + amount;

                    //adding the matching transactions to the listView (box)
                    listView_ServiceList.Items.Add(new ListViewItem(new string[]
                        { transactionDate, transactionType, cost}));
                }
            }      
            //show the total due
            txtBox_AmountDue.Text = total.ToString();
        }

        /// <summary>
        /// Method to open the new transaction form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_NewTransaction_Click(object sender, EventArgs e)
        {
            //button is enabled so user can choose it
            Btn_RefreshTransactionList.Enabled = true;
            Form_AddNewTransaction newTransaction = new Form_AddNewTransaction();
            newTransaction.Show();
        }

        private void Btn_RefreshTransactionList_Click(object sender, EventArgs e)
        {
            //refresh button disabled after refreshed
            listView_ServiceList.Clear();
            InitializeAddServiceForm();
            Btn_RefreshTransactionList.Enabled = false;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
