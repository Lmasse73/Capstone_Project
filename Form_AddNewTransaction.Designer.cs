
namespace Capstone_Project
{
    partial class Form_AddNewTransaction
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
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_CustId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBox_Services = new System.Windows.Forms.ComboBox();
            this.lbl_ServiceDescription = new System.Windows.Forms.Label();
            this.txtBox_Amount = new System.Windows.Forms.TextBox();
            this.Btn_AddService = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Name.Location = new System.Drawing.Point(36, 34);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.ReadOnly = true;
            this.txtBox_Name.Size = new System.Drawing.Size(358, 16);
            this.txtBox_Name.TabIndex = 0;
            this.txtBox_Name.Text = "Name";
            // 
            // txtBox_CustId
            // 
            this.txtBox_CustId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_CustId.Location = new System.Drawing.Point(36, 68);
            this.txtBox_CustId.Name = "txtBox_CustId";
            this.txtBox_CustId.ReadOnly = true;
            this.txtBox_CustId.Size = new System.Drawing.Size(358, 16);
            this.txtBox_CustId.TabIndex = 1;
            this.txtBox_CustId.Text = "Cust ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Service";
            // 
            // cmboBox_Services
            // 
            this.cmboBox_Services.FormattingEnabled = true;
            this.cmboBox_Services.Location = new System.Drawing.Point(36, 213);
            this.cmboBox_Services.Name = "cmboBox_Services";
            this.cmboBox_Services.Size = new System.Drawing.Size(165, 24);
            this.cmboBox_Services.TabIndex = 3;
            this.cmboBox_Services.SelectedIndexChanged += new System.EventHandler(this.cmboBox_Services_SelectedIndexChanged);
            // 
            // lbl_ServiceDescription
            // 
            this.lbl_ServiceDescription.AutoSize = true;
            this.lbl_ServiceDescription.Location = new System.Drawing.Point(33, 263);
            this.lbl_ServiceDescription.Name = "lbl_ServiceDescription";
            this.lbl_ServiceDescription.Size = new System.Drawing.Size(74, 16);
            this.lbl_ServiceDescription.TabIndex = 4;
            this.lbl_ServiceDescription.Text = "Description";
            // 
            // txtBox_Amount
            // 
            this.txtBox_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_Amount.Location = new System.Drawing.Point(165, 265);
            this.txtBox_Amount.Name = "txtBox_Amount";
            this.txtBox_Amount.ReadOnly = true;
            this.txtBox_Amount.Size = new System.Drawing.Size(68, 16);
            this.txtBox_Amount.TabIndex = 5;
            this.txtBox_Amount.Text = "Amount";
            // 
            // Btn_AddService
            // 
            this.Btn_AddService.Location = new System.Drawing.Point(51, 308);
            this.Btn_AddService.Name = "Btn_AddService";
            this.Btn_AddService.Size = new System.Drawing.Size(130, 41);
            this.Btn_AddService.TabIndex = 6;
            this.Btn_AddService.Text = "Add Service";
            this.Btn_AddService.UseVisualStyleBackColor = true;
            this.Btn_AddService.Click += new System.EventHandler(this.Btn_AddService_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.Location = new System.Drawing.Point(280, 308);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(150, 41);
            this.Btn_Back.TabIndex = 7;
            this.Btn_Back.Text = "Go Back to Transaction Window";
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "$";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(212, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 91);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Select a service from the dropo down menu and then \"add sevice\".   When you are d" +
    "one, go back to the the Transaction Window \r\nand refresh the list.";
            // 
            // Form_AddNewTransaction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_AddService);
            this.Controls.Add(this.txtBox_Amount);
            this.Controls.Add(this.lbl_ServiceDescription);
            this.Controls.Add(this.cmboBox_Services);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_CustId);
            this.Controls.Add(this.txtBox_Name);
            this.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_AddNewTransaction";
            this.Text = "Add New Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_CustId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBox_Services;
        private System.Windows.Forms.Label lbl_ServiceDescription;
        private System.Windows.Forms.TextBox txtBox_Amount;
        private System.Windows.Forms.Button Btn_AddService;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}