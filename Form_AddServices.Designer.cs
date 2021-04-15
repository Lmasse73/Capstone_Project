
namespace Capstone_Project
{
    partial class Form_AddServices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_ServiceList = new System.Windows.Forms.ListView();
            this.txtBox_CustId = new System.Windows.Forms.TextBox();
            this.txtBox_CustName = new System.Windows.Forms.TextBox();
            this.txtBox_AmountDue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_NewTransaction = new System.Windows.Forms.Button();
            this.Btn_RefreshTransactionList = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_ServiceList
            // 
            this.listView_ServiceList.GridLines = true;
            this.listView_ServiceList.HideSelection = false;
            this.listView_ServiceList.Location = new System.Drawing.Point(165, 12);
            this.listView_ServiceList.Name = "listView_ServiceList";
            this.listView_ServiceList.Size = new System.Drawing.Size(307, 191);
            this.listView_ServiceList.TabIndex = 0;
            this.listView_ServiceList.UseCompatibleStateImageBehavior = false;
            // 
            // txtBox_CustId
            // 
            this.txtBox_CustId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_CustId.Location = new System.Drawing.Point(12, 80);
            this.txtBox_CustId.Name = "txtBox_CustId";
            this.txtBox_CustId.ReadOnly = true;
            this.txtBox_CustId.Size = new System.Drawing.Size(116, 16);
            this.txtBox_CustId.TabIndex = 1;
            this.txtBox_CustId.Text = "Customer ID";
            // 
            // txtBox_CustName
            // 
            this.txtBox_CustName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_CustName.Location = new System.Drawing.Point(12, 42);
            this.txtBox_CustName.Name = "txtBox_CustName";
            this.txtBox_CustName.ReadOnly = true;
            this.txtBox_CustName.Size = new System.Drawing.Size(116, 16);
            this.txtBox_CustName.TabIndex = 2;
            this.txtBox_CustName.Text = "Name";
            // 
            // txtBox_AmountDue
            // 
            this.txtBox_AmountDue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_AmountDue.Location = new System.Drawing.Point(256, 220);
            this.txtBox_AmountDue.Name = "txtBox_AmountDue";
            this.txtBox_AmountDue.ReadOnly = true;
            this.txtBox_AmountDue.Size = new System.Drawing.Size(69, 16);
            this.txtBox_AmountDue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Due";
            // 
            // Btn_NewTransaction
            // 
            this.Btn_NewTransaction.Location = new System.Drawing.Point(19, 315);
            this.Btn_NewTransaction.Name = "Btn_NewTransaction";
            this.Btn_NewTransaction.Size = new System.Drawing.Size(136, 34);
            this.Btn_NewTransaction.TabIndex = 6;
            this.Btn_NewTransaction.Text = "New Transaction";
            this.Btn_NewTransaction.UseVisualStyleBackColor = true;
            this.Btn_NewTransaction.Click += new System.EventHandler(this.Btn_NewTransaction_Click);
            // 
            // Btn_RefreshTransactionList
            // 
            this.Btn_RefreshTransactionList.Location = new System.Drawing.Point(190, 315);
            this.Btn_RefreshTransactionList.Name = "Btn_RefreshTransactionList";
            this.Btn_RefreshTransactionList.Size = new System.Drawing.Size(107, 34);
            this.Btn_RefreshTransactionList.TabIndex = 7;
            this.Btn_RefreshTransactionList.Text = "Refresh List";
            this.Btn_RefreshTransactionList.UseVisualStyleBackColor = true;
            this.Btn_RefreshTransactionList.Click += new System.EventHandler(this.Btn_RefreshTransactionList_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(336, 315);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(122, 34);
            this.Btn_Back.TabIndex = 8;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "$";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(21, 257);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(442, 37);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Go to \"New Transaction\" to add a service or enter a payment.  The list must be Re" +
    "freshed to add the transaction to the total.\r\n";
            // 
            // Form_AddServices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_RefreshTransactionList);
            this.Controls.Add(this.Btn_NewTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_AmountDue);
            this.Controls.Add(this.txtBox_CustName);
            this.Controls.Add(this.txtBox_CustId);
            this.Controls.Add(this.listView_ServiceList);
            this.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_AddServices";
            this.Text = "Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_ServiceList;
        private System.Windows.Forms.TextBox txtBox_CustId;
        private System.Windows.Forms.TextBox txtBox_CustName;
        private System.Windows.Forms.TextBox txtBox_AmountDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_NewTransaction;
        private System.Windows.Forms.Button Btn_RefreshTransactionList;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}