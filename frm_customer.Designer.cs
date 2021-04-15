
namespace Capstone_Project
{
    partial class frm_customer
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
            this.cmbBox_CustList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addcust = new System.Windows.Forms.Button();
            this.btn_refresh_customer_list = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Services = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBox_CustList
            // 
            this.cmbBox_CustList.FormattingEnabled = true;
            this.cmbBox_CustList.Location = new System.Drawing.Point(40, 63);
            this.cmbBox_CustList.MinimumSize = new System.Drawing.Size(200, 0);
            this.cmbBox_CustList.Name = "cmbBox_CustList";
            this.cmbBox_CustList.Size = new System.Drawing.Size(200, 28);
            this.cmbBox_CustList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer List";
            // 
            // btn_addcust
            // 
            this.btn_addcust.Location = new System.Drawing.Point(40, 147);
            this.btn_addcust.Name = "btn_addcust";
            this.btn_addcust.Size = new System.Drawing.Size(131, 29);
            this.btn_addcust.TabIndex = 2;
            this.btn_addcust.Text = "Add Customer";
            this.btn_addcust.UseVisualStyleBackColor = true;
            this.btn_addcust.Click += new System.EventHandler(this.btn_addcust_Click);
            // 
            // btn_refresh_customer_list
            // 
            this.btn_refresh_customer_list.Location = new System.Drawing.Point(265, 147);
            this.btn_refresh_customer_list.Name = "btn_refresh_customer_list";
            this.btn_refresh_customer_list.Size = new System.Drawing.Size(131, 29);
            this.btn_refresh_customer_list.TabIndex = 3;
            this.btn_refresh_customer_list.Text = "Refresh List";
            this.btn_refresh_customer_list.UseVisualStyleBackColor = true;
            this.btn_refresh_customer_list.Click += new System.EventHandler(this.btn_refresh_customer_list_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 205);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(356, 57);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "After adding a new customer, please refresh the list.  New customers will not be " +
    "in the customer list until the list is refreshed.\r\n\r\n";
            // 
            // Btn_Services
            // 
            this.Btn_Services.Location = new System.Drawing.Point(40, 286);
            this.Btn_Services.Name = "Btn_Services";
            this.Btn_Services.Size = new System.Drawing.Size(200, 31);
            this.Btn_Services.TabIndex = 5;
            this.Btn_Services.Text = "View/Add Services";
            this.Btn_Services.UseVisualStyleBackColor = true;
            this.Btn_Services.Click += new System.EventHandler(this.Btn_Services_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(321, 286);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(75, 30);
            this.Btn_Back.TabIndex = 6;
            this.Btn_Back.Text = "Back";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // frm_customer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Services);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_refresh_customer_list);
            this.Controls.Add(this.btn_addcust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBox_CustList);
            this.Font = new System.Drawing.Font("Proxima Nova Rg", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_customer";
            this.Text = "Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBox_CustList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addcust;
        private System.Windows.Forms.Button btn_refresh_customer_list;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_Services;
        private System.Windows.Forms.Button Btn_Back;
    }
}