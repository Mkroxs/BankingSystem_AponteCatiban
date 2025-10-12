using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Dashboard_Cus: UserControl
    {
       
        public UC_Dashboard_Cus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.login.BringToFront();
        }

        private void lbldeposit_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.deposit_customer.BringToFront();
        }

        private void lblcheck_bal_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            if (mainform != null)
            {
                mainform.checkBalance_Cus.LoadCustomerData(); 
                mainform.checkBalance_Cus.BringToFront();
            }
        }

        private void lbltransac_history_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            if (mainform != null)
            {
                mainform.transactionHistory.LoadTransactionHistory();
                mainform.transactionHistory.BringToFront();
            }
        }

        private void lblprof_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            if(mainform != null)
            {
                mainform.profile.BringToFront();
                mainform.profile.LoadCustomerData();
            }
        }

       
        
        private void UC_Dashboard_Cus_Load(object sender, EventArgs e)
        {

        }
    }
}
