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
    public partial class Form_AddNewTransaction : Form
    {

        bool paymentSelected = false;
        public Form_AddNewTransaction()
        {
            InitializeComponent();
            InitializeForm();       
        }

        /// <summary>
        /// Method to load the combobox with the service list
        /// </summary>
        private void InitializeForm()
        {
            cmboBox_Services.DataSource = Enum.GetNames(typeof(HomeClass.ServiceList));

            //show the name and ID on the form
            txtBox_Name.Text = HomeClass.GetCustName();
            txtBox_CustId.Text = HomeClass.GetCustId();
        }

        /// <summary>
        /// Method gets user service selection, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmboBox_Services_SelectedIndexChanged(object sender, EventArgs e)
        {
            Btn_AddService.Enabled = true;
            double amount = 0;
            string selection = cmboBox_Services.SelectedItem.ToString();

            Enum.TryParse(selection, out HomeClass.ServiceList service);

            //if payment, enabling the textbox Amount to enter a payment amount
            if (service == HomeClass.ServiceList.Payment)
            {
                paymentSelected = true;
                txtBox_Amount.ReadOnly = false;
                txtBox_Amount.Clear();
                lbl_ServiceDescription.Text = "Enter Payment Amount";
                
            }
            else
            {
                //otherwise show the cost of the service in the textbox Amount

                paymentSelected = false;
                amount = HomeClass.ServiceAndCost[service];
                lbl_ServiceDescription.Text = "Cost for " + selection;
                txtBox_Amount.ReadOnly = true;
                txtBox_Amount.Text = amount.ToString();   
            }
        }

        /// <summary>
        /// Method button to validate the selection was made
        /// and update the transaction list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_AddService_Click(object sender, EventArgs e)
        {
            bool goodTransaction = false;
            double amount = 0;
            if (cmboBox_Services.SelectedItem ==null)
            {
                MessageBox.Show("Must select a service.");
            }
            else
            {
                if (paymentSelected)
                {
                    if (txtBox_Amount.Text=="")
                    {
                        MessageBox.Show("Please Enter a Payment Amount");
                    }
                    else
                    {
                        double.TryParse(txtBox_Amount.Text, out amount);
                        amount *= -1;
                        goodTransaction = true;
                    }
                }
                else
                {
                    double.TryParse(txtBox_Amount.Text, out amount);
                    goodTransaction = true;
                }

                if (goodTransaction)
                {
                    //update transaction list
                    string transactionDate = DateTime.Now.ToString("MM/dd/yyyy");
                    string custID = HomeClass.GetCustId();
                    string selectedService = cmboBox_Services.SelectedItem.ToString();
                    string newTransaction = custID + "," + transactionDate + "," + selectedService + "," + amount.ToString();
                    HomeClass.CustomerServicesList.Add(newTransaction);
                    Btn_AddService.Enabled = false;
                    MessageBox.Show("Transaction Complete.  Go Back or Add Another.");
                }

            }
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
