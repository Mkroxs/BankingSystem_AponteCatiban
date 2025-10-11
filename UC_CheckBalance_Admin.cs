using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_CheckBalance_Admin : UserControl
    {
        private List<Customer> customers = new List<Customer>();
        private Customer selectedCustomer = null;

        public UC_CheckBalance_Admin()
        {
            InitializeComponent();
        }

        private void UC_CheckBalance_Admin_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            SetupAccountNumberAutocomplete();
        }

        public void LoadCustomers()
        {
            try
            {
                customers = DataStore.LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers:\n" + ex.Message);
            }
        }

        public void SetupAccountNumberAutocomplete()
        {
            if (customers == null || customers.Count == 0)
                return;

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(customers.Select(c => c.AccountNumber).ToArray());

            tbxAccountNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxAccountNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxAccountNumber.AutoCompleteCustomSource = autoComplete;
        }

        private void tbxAccountNumber_TextChanged(object sender, EventArgs e)
        {
            string input = tbxAccountNumber.Text.Trim();

            
            LoadCustomers();

            if (string.IsNullOrWhiteSpace(input))
            {
                lbl_accnum.Text = "-";
                lbl_accname.Text = "-";
                lbl_rembal.Text = "₱0.00";
                return;
            }

            selectedCustomer = customers.FirstOrDefault(c =>
                c.AccountNumber.Equals(input, StringComparison.OrdinalIgnoreCase));

            if (selectedCustomer != null)
            {
                lbl_accnum.Text = selectedCustomer.AccountNumber;
                lbl_accname.Text = selectedCustomer.FullName;
                lbl_rembal.Text = $"₱{selectedCustomer.Balance:N2}";
            }
            else
            {
                lbl_accnum.Text = "No account found";
                lbl_accname.Text = "-";
                lbl_rembal.Text = "₱0.00";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.dashboard_Admin.BringToFront();
            tbxAccountNumber.Text = string.Empty;
        }

        private void lbl_accnum_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void lbl_accname_Click(object sender, EventArgs e) { }

        private void lbl_rembal_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }
    }
}
