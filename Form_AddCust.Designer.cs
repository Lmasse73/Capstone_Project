
namespace Capstone_Project
{
    partial class Form_AddCust
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_first = new System.Windows.Forms.TextBox();
            this.txtbox_last = new System.Windows.Forms.TextBox();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.btn_savecust = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txtbox_first
            // 
            this.txtbox_first.Location = new System.Drawing.Point(120, 46);
            this.txtbox_first.Name = "txtbox_first";
            this.txtbox_first.Size = new System.Drawing.Size(154, 20);
            this.txtbox_first.TabIndex = 3;
            // 
            // txtbox_last
            // 
            this.txtbox_last.Location = new System.Drawing.Point(120, 105);
            this.txtbox_last.Name = "txtbox_last";
            this.txtbox_last.Size = new System.Drawing.Size(154, 20);
            this.txtbox_last.TabIndex = 4;
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(120, 165);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(154, 20);
            this.txtbox_email.TabIndex = 5;
            // 
            // btn_savecust
            // 
            this.btn_savecust.Location = new System.Drawing.Point(36, 252);
            this.btn_savecust.Name = "btn_savecust";
            this.btn_savecust.Size = new System.Drawing.Size(153, 23);
            this.btn_savecust.TabIndex = 6;
            this.btn_savecust.Text = "Save Customer";
            this.btn_savecust.UseVisualStyleBackColor = true;
            this.btn_savecust.Click += new System.EventHandler(this.btn_savecust_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(289, 252);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(145, 23);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Form_AddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_savecust);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.txtbox_last);
            this.Controls.Add(this.txtbox_first);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_AddCust";
            this.Text = "Add New Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_first;
        private System.Windows.Forms.TextBox txtbox_last;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Button btn_savecust;
        private System.Windows.Forms.Button btn_back;
    }
}