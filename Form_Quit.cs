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
    public partial class Form_Quit : Form
    {
        public Form_Quit()
        {
            InitializeComponent();
        }

        private void Btn_Quit_App_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
