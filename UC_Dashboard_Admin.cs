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
        bool sidebarExpand;
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

        private void lblregister_MouseEnter(object sender, EventArgs e)
        {
            lblregister.ForeColor = Color.Black;
        }

        private void lblregister_MouseLeave(object sender, EventArgs e)
        {
            lblregister.ForeColor = Color.White;
        }

        private void lbldeposit_MouseEnter(object sender, EventArgs e)
        {
            lbldeposit.ForeColor = Color.Black;
        }

        private void lbldeposit_MouseLeave(object sender, EventArgs e)
        {
            lbldeposit.ForeColor = Color.White;
        }

        private void lblwithdraw_MouseEnter(object sender, EventArgs e)
        {
            lblwithdraw.ForeColor = Color.Black;
        }

        private void lblwithdraw_MouseLeave(object sender, EventArgs e)
        {
            lblwithdraw.ForeColor = Color.White;
        }

        private void lblcheck_bal_MouseEnter(object sender, EventArgs e)
        {
            lblcheck_bal.ForeColor = Color.Black;
        }

        private void lblcheck_bal_MouseLeave(object sender, EventArgs e)
        {
            lblcheck_bal.ForeColor = Color.White;
        }

        private void lblcus_prof_MouseEnter(object sender, EventArgs e)
        {
            lblcus_prof.ForeColor = Color.Black;
        }

        private void lblcus_prof_MouseLeave(object sender, EventArgs e)
        {
            lblcus_prof.ForeColor = Color.White;
        }

        private void lbllogout_MouseEnter(object sender, EventArgs e)
        {
            lbllogout.ForeColor = Color.Black;
        }

        private void lbllogout_MouseLeave(object sender, EventArgs e)
        {
            lbllogout.ForeColor = Color.White;
        }
    }
}
