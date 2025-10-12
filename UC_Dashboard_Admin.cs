using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Dashboard_Admin : UserControl
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

        }

        private void label1_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.login.BringToFront();
        }

        private void lblregister_Click_2(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.registration.BringToFront();
            mainform.registration.Show();
        }

        private void lblcheck_bal_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.checkBalance_Admin.BringToFront();
        }

        private void lblcus_prof_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;

            if (mainform.customerProfile.LoadCustomerData(true))
            {
                mainform.customerProfile.BringToFront();
            }
        }

        private void lblwithdraw_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.withdraw.BringToFront();
        }

        private void lbldeposit_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.deposit_Admin.BringToFront();
        }

        private void UC_Dashboard_Admin_Load_1(object sender, EventArgs e)
        {

        }

       

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
