using BankingSystem_AponteCatiban.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Helpers;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Withdraw : UserControl
    {
        private List<Customer> customers = new List<Customer>();
        private Customer selectedCustomer = null;

        public UC_Withdraw()
        {
            InitializeComponent();
            this.VisibleChanged += UC_Withdraw_VisibleChanged;
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }


        private void UC_Withdraw_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void UC_Withdraw_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                LoadCustomerData();
        }

        private void LoadCustomerData()
        {

            customers = DataStore.LoadCustomers();
            if (customers == null || customers.Count == 0)
                return;

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(customers.Select(c => c.AccountNumber).ToArray());

            txtbx_accnum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtbx_accnum.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtbx_accnum.AutoCompleteCustomSource = autoComplete;
        }

        public void RefreshCustomerList()
        {
            LoadCustomerData();

            if (selectedCustomer != null)
            {
                selectedCustomer = customers.FirstOrDefault(c => c.AccountNumber == selectedCustomer.AccountNumber);
                if (selectedCustomer != null)
                {
                    lbl_currbal.Text = $"₱{selectedCustomer.Balance:N2}";
                    lbl_newbal.Text = $"₱{selectedCustomer.Balance:N2}";
                }
            }
        }


        private void txtbx_accnum_TextChanged(object sender, EventArgs e)
        {
            string input = txtbx_accnum.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                ClearField();
                txtbx_amount.Enabled = false;
                return;
            }

            selectedCustomer = customers.FirstOrDefault(c => c.AccountNumber.Equals(input, StringComparison.OrdinalIgnoreCase));

            if (selectedCustomer != null)
            {
                lblAccountName.Text = selectedCustomer.FullName;
                lbl_currbal.Text = $"₱{selectedCustomer.Balance:N2}";
                lblAmount.Text = "₱0.00";
                lbl_newbal.Text = $"₱{selectedCustomer.Balance:N2}";
                txtbx_amount.Enabled = true;
            }
            else
            {
                lblAccountName.Text = "No user found with that account number.";
                lbl_currbal.Text = "₱0.00";
                lbl_newbal.Text = "₱0.00";
                lblAmount.Text = "₱0.00";
                txtbx_amount.Enabled = false;
            }
        }

        private void txtbx_accnum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }


        private void txtbx_amount_TextChanged(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                lblAmount.Text = "₱0.00";
                lbl_newbal.Text = "₱0.00";
                return;
            }

            if (decimal.TryParse(txtbx_amount.Text, out decimal enteredAmount))
            {
                if (enteredAmount > selectedCustomer.Balance)
                {
                    enteredAmount = selectedCustomer.Balance;
                    txtbx_amount.Text = enteredAmount.ToString("0.00");
                    txtbx_amount.SelectionStart = txtbx_amount.Text.Length;
                }

                lblAmount.Text = $"₱{enteredAmount:N2}";
                lbl_newbal.Text = $"₱{selectedCustomer.Balance - enteredAmount:N2}";
            }
            else
            {
                lblAmount.Text = "₱0.00";
                lbl_newbal.Text = $"₱{selectedCustomer.Balance:N2}";
            }
        }

        private void txtbx_amount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }


        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please enter a valid account number.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtbx_amount.Text, out decimal withdrawAmount) || withdrawAmount <= 0)
            {
                MessageBox.Show("Please enter a valid amount to withdraw.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (withdrawAmount > selectedCustomer.Balance)
            {
                MessageBox.Show("Withdrawal amount exceeds current balance.", "Insufficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal oldBalance = selectedCustomer.Balance;
            selectedCustomer.Balance -= withdrawAmount;
            DataStore.UpdateCustomerBalance(selectedCustomer.AccountNumber, selectedCustomer.Balance);

            Transaction transaction = new Transaction
            {
                customerAccountNumber = selectedCustomer.AccountNumber,
                type = "Withdraw",
                amount = withdrawAmount,
                previousBalance = oldBalance,
                newBalance = selectedCustomer.Balance,
                date = DateTime.Now.ToString("MMMM dd, yyyy")
            };
            DataStore.AppendTransaction(transaction);

            MessageBox.Show($"Withdrawal successful!\n\nNew Balance: ₱{selectedCustomer.Balance:N2}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var mainform = this.FindForm() as MainForm;
            if (mainform != null)
            {

                mainform.withdraw?.RefreshCustomerList();
                mainform.deposit_Admin?.RefreshCustomerList();
                mainform.checkBalance_Admin?.LoadCustomers();
                mainform.checkBalance_Admin?.SetupAccountNumberAutocomplete();
            }

            lbl_currbal.Text = $"₱{selectedCustomer.Balance:N2}";
            lbl_newbal.Text = $"₱{selectedCustomer.Balance:N2}";
            ClearField();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearField();
        }


        private void ClearField()
        {
            txtbx_accnum.Clear();
            txtbx_amount.Clear();
            lblAccountName.Text = "—";
            lbl_currbal.Text = "₱0.00";
            lbl_newbal.Text = "₱0.00";
            lblAmount.Text = "₱0.00";
            txtbx_amount.Enabled = false;
            selectedCustomer = null;
        }


        private void lblAccountName_Click(object sender, EventArgs e)
        {

        }
    }
}
