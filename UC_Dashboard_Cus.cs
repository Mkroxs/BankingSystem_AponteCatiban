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
        bool sidebarExpand;
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

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void lbldeposit_MouseEnter(object sender, EventArgs e)
        {
            lbldeposit.ForeColor = Color.Black;
        }

        private void lbldeposit_MouseLeave(object sender, EventArgs e)
        {
            lbldeposit.ForeColor = Color.White;
        }

        private void lblcheck_bal_MouseEnter(object sender, EventArgs e)
        {
            lblcheck_bal.ForeColor = Color.Black;
        }

        private void lblcheck_bal_MouseLeave(object sender, EventArgs e)
        {
            lblcheck_bal.ForeColor= Color.White;
        }

        private void lbltransac_history_MouseEnter(object sender, EventArgs e)
        {
            lbltransac_history.ForeColor = Color.Black;
        }

        private void lbltransac_history_MouseLeave(object sender, EventArgs e)
        {
            lbltransac_history.ForeColor= Color.White;
        }

        private void lblprof_MouseEnter(object sender, EventArgs e)
        {
            lblprof.ForeColor = Color.Black;
        }

        private void lblprof_MouseLeave(object sender, EventArgs e)
        {
            lblprof.ForeColor= Color.White;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lblllogout.ForeColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            lblllogout.ForeColor = Color.White;
        }
    }
}
