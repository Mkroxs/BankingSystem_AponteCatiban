using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;

namespace BankingSystem_AponteCatiban
{
    public partial class Frm_CheckBalance : Form
    {
        private List<Customer> customers = new List<Customer>();
        private Customer selectedCustomer = null;
        private MainForm mainform;

        public Frm_CheckBalance(MainForm parentForm)
        {
            InitializeComponent();
            mainform = parentForm;
        }

        private void Frm_CheckBalance_Load(object sender, EventArgs e)
        {
            // Load all customers for admin lookup
            customers = DataStore.LoadCustomers();

            if (IsAdmin())
            {
                panelAccountInput.Visible = true;
                SetupAccountNumberAutocomplete();
            }
            else
            {
                panelAccountInput.Visible = false;
                ShowCustomerBalance(mainform.LoggedInCustomer);
            }
        }

        private bool IsAdmin()
        {
            // if no logged in customer → it's admin
            return mainform.LoggedInCustomer == null;
        }

        private void SetupAccountNumberAutocomplete()
        {
            if (customers.Count == 0) return;

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(customers.Select(c => c.AccountNumber).ToArray());

            tbxAccountNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbxAccountNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbxAccountNumber.AutoCompleteCustomSource = autoComplete;
        }

        private void tbxAccountNumber_TextChanged(object sender, EventArgs e)
        {
            string input = tbxAccountNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                ClearLabels();
                return;
            }

            selectedCustomer = customers.FirstOrDefault(c =>
                c.AccountNumber.Equals(input, StringComparison.OrdinalIgnoreCase));

            if (selectedCustomer != null)
            {
                ShowCustomerBalance(selectedCustomer);
            }
            else
            {
                lbl_accnum.Text = "No account found";
                lbl_accname.Text = "-";
                lbl_rembal.Text = "₱0.00";
            }
        }

        private void tbxAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ShowCustomerBalance(Customer customer)
        {
            lbl_accnum.Text = customer.AccountNumber;
            lbl_accname.Text = customer.FullName;
            lbl_rembal.Text = $"₱{customer.Balance:N2}";
        }

        private void ClearLabels()
        {
            lbl_accnum.Text = "-";
            lbl_accname.Text = "-";
            lbl_rembal.Text = "₱0.00";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
