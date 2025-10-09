using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Dashboard_Admin: UserControl
    {

        public UC_Dashboard_Admin()
        {
            InitializeComponent();

        }

        private void UC_Dashboard_Admin_Load(object sender, EventArgs e)
        {

        }

        private void lblregister_Click(object sender, EventArgs e)
        {
            
        }

        private void lblregister_Click_1(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;

            mainform.registration.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
