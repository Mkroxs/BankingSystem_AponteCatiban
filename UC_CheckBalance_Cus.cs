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
using Newtonsoft.Json;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_CheckBalance_Cus : UserControl
    {
        public UC_CheckBalance_Cus()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void lbl_accnum_Click(object sender, EventArgs e)
        {
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
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

                // ✅ Properly formatted remaining balance with peso sign and commas
                lbl_rembal.Text = $"₱{customer.Balance:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading balance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
