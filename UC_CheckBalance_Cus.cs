using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BankingSystem_AponteCatiban.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_CheckBalance_Cus: UserControl
    {
        public UC_CheckBalance_Cus()
        {
            InitializeComponent();
        }

        private void lbl_accnum_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.dashboard_Cus.BringToFront();
        }

        public void LoadCustomerData()
        {
            try
            {
                var mainform = this.FindForm() as MainForm; 
                if (mainform == null || mainform.LoggedInCustomer == null)
                {
                    return;
                }
                Customer customer = mainform.LoggedInCustomer;

                lbl_accnum.Text = customer.AccountNumber;
                lbl_accname.Text = customer.FullName;
                lbl_rembal.Text = $"${customer.Balance:F2}";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                LoadCustomerData();
            }
        }


        private void UC_CheckBalance_Cus_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
    }
}
