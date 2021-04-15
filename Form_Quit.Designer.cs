
namespace Capstone_Project
{
    partial class Form_Quit
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_Quit_App = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(98, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(284, 168);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Application is updated with your changes.  \r\n\r\nThank you.\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_Quit_App
            // 
            this.Btn_Quit_App.BackColor = System.Drawing.Color.Lavender;
            this.Btn_Quit_App.Location = new System.Drawing.Point(137, 233);
            this.Btn_Quit_App.Name = "Btn_Quit_App";
            this.Btn_Quit_App.Size = new System.Drawing.Size(210, 50);
            this.Btn_Quit_App.TabIndex = 1;
            this.Btn_Quit_App.Text = "Quit Application";
            this.Btn_Quit_App.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Quit_App.UseVisualStyleBackColor = false;
            this.Btn_Quit_App.Click += new System.EventHandler(this.Btn_Quit_App_Click);
            // 
            // Form_Quit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Btn_Quit_App);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_Quit";
            this.Text = "Form_Quit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_Quit_App;
    }
}