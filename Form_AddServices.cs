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

        private void InitializeAddServiceForm()
        {
            txtBox_CustId.Text = "Cust ID " + HomeClass.GetCustId();
            string custID = HomeClass.GetCustId();
            txtBox_CustName.Text = HomeClass.GetCustName();

            double total = 0;
            double amount;

            listView_ServiceList.View = View.Details;
            listView_ServiceList.Columns.Add("Date", 100);
            listView_ServiceList.Columns.Add("Service", 100);
            listView_ServiceList.Columns.Add("Cost", -2);

            foreach (string transaction in HomeClass.CustomerServicesList)
            {
                string[] transactionItems = transaction.Split(',');

                if (transactionItems[0] == custID)
                {
                    string transactionDate = transactionItems[1].ToString();
                    string transactionType = transactionItems[2].ToString();
                    string cost = transactionItems[3].ToString();

                    double.TryParse(cost, out amount);
                    total = total + amount;

                    listView_ServiceList.Items.Add(new ListViewItem(new string[]
                        { transactionDate, transactionType, cost}));
                }
            }
            txtBox_AmountDue.Text = total.ToString();
        }


        private void Btn_NewTransaction_Click(object sender, EventArgs e)
        {
            Btn_RefreshTransactionList.Enabled = true;
            Form_AddNewTransaction newTransaction = new Form_AddNewTransaction();
            newTransaction.Show();
        }

        private void Btn_RefreshTransactionList_Click(object sender, EventArgs e)
        {
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
