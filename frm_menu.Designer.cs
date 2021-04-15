
namespace Capstone_Project
{
    partial class frm_menu
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
            this.btn_quit = new System.Windows.Forms.Button();
            this.Btn_Cust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Proxima Nova Rg", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // btn_quit
            // 
            this.btn_quit.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(301, 199);
            this.btn_quit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(141, 50);
            this.btn_quit.TabIndex = 5;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // Btn_Cust
            // 
            this.Btn_Cust.Font = new System.Drawing.Font("Proxima Nova Rg", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cust.Location = new System.Drawing.Point(31, 199);
            this.Btn_Cust.Name = "Btn_Cust";
            this.Btn_Cust.Size = new System.Drawing.Size(203, 50);
            this.Btn_Cust.TabIndex = 6;
            this.Btn_Cust.Text = "View or Create a Customer";
            this.Btn_Cust.UseVisualStyleBackColor = true;
            this.Btn_Cust.Click += new System.EventHandler(this.Btn_Cust_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Btn_Cust);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Proxima Nova Rg", 8.099999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_menu";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button Btn_Cust;
    }
}