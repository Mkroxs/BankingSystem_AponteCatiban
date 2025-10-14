using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Deposit_Admin : UserControl
    {
        private List<Customer> customers;
        private Customer selectedCustomer;
        private decimal depositTotal = 0;

        public UC_Deposit_Admin()
        {
            InitializeComponent();
            this.VisibleChanged += UC_Deposit_Admin_VisibleChanged;
        }

        
        public void RefreshCustomerList()
        {
            LoadCustomers();
            SetupAccountNumberAutocomplete();
        }

        private void UC_Deposit_Admin_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            SetupAccountNumberAutocomplete();
            EnableDenominations(false);
        }

        private void UC_Deposit_Admin_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadCustomers();
                SetupAccountNumberAutocomplete();
            }
        }

       
        private void LoadCustomers()
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

        private void SetupAccountNumberAutocomplete()
        {
            customers = DataStore.LoadCustomers();
            if (customers == null || customers.Count == 0)
                return;

            txt_accnum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_accnum.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(customers.Select(c => c.AccountNumber).ToArray());
            txt_accnum.AutoCompleteCustomSource = autoComplete;
        }

        
        private void ClearCustomerDisplay()
        {
            lbl_accname.Text = "-";
            lbl_currbal.Text = "₱0.00";
            depositTotal = 0;
            lbl_totalamount.Text = "₱0.00";
            ClearDenominations();
        }

        private void ClearDenominations()
        {
            txt1000.Clear();
            txt500.Clear();
            txt200.Clear();
            txt100.Clear();
            txt50.Clear();
            txt20.Clear();
            txt10.Clear();
            txt5.Clear();
            txt1.Clear();
            depositTotal = 0;
            lbl_totalamount.Text = "₱0.00";
        }

        
        private void txt_accnum_TextChanged(object sender, EventArgs e)
        {
            if (customers == null || customers.Count == 0)
                LoadCustomers();

            string accNum = txt_accnum.Text.Trim();

            if (string.IsNullOrWhiteSpace(accNum))
            {
                lbl_NoAccount.Visible = false;
                ClearCustomerDisplay();
                EnableDenominations(false);
                selectedCustomer = null;
                return;
            }

            selectedCustomer = customers.FirstOrDefault(c =>
                c.AccountNumber.Equals(accNum, StringComparison.OrdinalIgnoreCase));

            if (selectedCustomer != null)
            {
                lbl_NoAccount.Visible = false;
                lbl_accname.Text = selectedCustomer.FullName;
                lbl_currbal.Text = $"₱{selectedCustomer.Balance:N2}";
                EnableDenominations(true);
            }
            else
            {
                lbl_NoAccount.Visible = true;
                ClearCustomerDisplay();
                EnableDenominations(false);
                selectedCustomer = null;
            }
        }

       
        private void EnableDenominations(bool enable)
        {
            txt1000.Enabled = enable;
            txt500.Enabled = enable;
            txt200.Enabled = enable;
            txt100.Enabled = enable;
            txt50.Enabled = enable;
            txt20.Enabled = enable;
            txt10.Enabled = enable;
            txt5.Enabled = enable;
            txt1.Enabled = enable;
        }

       
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (selectedCustomer == null)
            {
                MessageBox.Show("Please select a valid account first.", "Invalid Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (depositTotal <= 0)
            {
                MessageBox.Show("Please select a deposit amount.", "No Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal previousBalance = selectedCustomer.Balance;
            selectedCustomer.Balance += depositTotal;
            DataStore.UpdateCustomerBalance(selectedCustomer.AccountNumber, selectedCustomer.Balance);

            Transaction transaction = new Transaction
            {
                customerAccountNumber = selectedCustomer.AccountNumber,
                type = "Deposit",
                amount = depositTotal,
                previousBalance = previousBalance,
                newBalance = selectedCustomer.Balance,
                date = DateTime.Now.ToString("MMMM dd, yyyy")
            };
            DataStore.AppendTransaction(transaction);

            MessageBox.Show(
                $"Deposit Successful!\n\nAccount: {selectedCustomer.AccountNumber}\nAmount: ₱{depositTotal:N2}\nNew Balance: ₱{selectedCustomer.Balance:N2}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            var mainform = this.FindForm() as MainForm;
            if (mainform != null)
            {
                mainform.deposit_Admin?.RefreshCustomerList();
                mainform.withdraw?.RefreshCustomerList();
                mainform.checkBalance_Admin?.LoadCustomers();
                mainform.checkBalance_Admin?.SetupAccountNumberAutocomplete();
            }

            ClearCustomerDisplay();
            txt_accnum.Clear();
            selectedCustomer = null;
        }

        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearCustomerDisplay();
            txt_accnum.Clear();
            selectedCustomer = null;
        }

        
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearDenominations();
        }

        
        private void AddDeposit(decimal amount)
        {
            depositTotal += amount;
            lbl_totalamount.Text = $"₱{depositTotal:N2}";
        }

        
        private void btn_1000_Click(object sender, EventArgs e) => AddDeposit(1000);
        private void btn_500_Click(object sender, EventArgs e) => AddDeposit(500);
        private void btn_200_Click(object sender, EventArgs e) => AddDeposit(200);
        private void btn_100_Click(object sender, EventArgs e) => AddDeposit(100);
        private void btn_50_Click(object sender, EventArgs e) => AddDeposit(50);
        private void btn_20_Click(object sender, EventArgs e) => AddDeposit(20);
        private void btn_10_Click(object sender, EventArgs e) => AddDeposit(10);
        private void btn_5_Click(object sender, EventArgs e) => AddDeposit(5);
        private void btn_1_Click(object sender, EventArgs e) => AddDeposit(1);

        
        private void txt1000_TextChanged(object sender, EventArgs e) => CalculateDepositTotal();
        private void txt500_TextChanged(object sender, EventArgs e) => CalculateDepositTotal();
        private void txt200_TextChanged(object sender, EventArgs e) => CalculateDepositTotal();
        private void txt100_TextChanged(object sender, EventArgs e) => CalculateDepositTotal();
        private void txt50_TextChanged(object sender, EventArgs e) => CalculateDepositTotal();
        private void txt20_TextChanged(object sender, EventArgs e) => CalculateDepositTotal();
        private void txt10_TextChanged(object sender, EventArgs e) => CalculateDepositTotal();
        private void txt5_TextChanged(object sender, EventArgs e) => CalculateDepositTotal();
        private void txt1_TextChanged(object sender, EventArgs e) => CalculateDepositTotal();

        private void CalculateDepositTotal()
        {
            decimal total = 0;

            total += ParseDecimal(txt1000.Text) * 1000;
            total += ParseDecimal(txt500.Text) * 500;
            total += ParseDecimal(txt200.Text) * 200;
            total += ParseDecimal(txt100.Text) * 100;
            total += ParseDecimal(txt50.Text) * 50;
            total += ParseDecimal(txt20.Text) * 20;
            total += ParseDecimal(txt10.Text) * 10;
            total += ParseDecimal(txt5.Text) * 5;
            total += ParseDecimal(txt1.Text) * 1;

            depositTotal = total;
            lbl_totalamount.Text = $"₱{depositTotal:N2}";
        }

        private int ParseDecimal(string text)
        {
            if (int.TryParse(text, out int value) && value >= 0)
                return value;
            return 0;
        }

        
        private void TextBox_KeyPress_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        
        private void txt1000_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);
        private void txt500_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);
        private void txt200_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);
        private void txt100_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);
        private void txt50_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);
        private void txt20_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);
        private void txt10_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);
        private void txt5_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);
        private void txt1_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);
        private void txt_accnum_KeyPress(object sender, KeyPressEventArgs e) => TextBox_KeyPress_Numeric(sender, e);

        
        private void TextBox_Enter_Clear(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
                tb.Clear();
        }

        private void txt1000_Enter(object sender, EventArgs e) => TextBox_Enter_Clear(sender, e);
        private void txt500_Enter(object sender, EventArgs e) => TextBox_Enter_Clear(sender, e);
        private void txt200_Enter(object sender, EventArgs e) => TextBox_Enter_Clear(sender, e);
        private void txt100_Enter(object sender, EventArgs e) => TextBox_Enter_Clear(sender, e);
        private void txt50_Enter(object sender, EventArgs e) => TextBox_Enter_Clear(sender, e);
        private void txt20_Enter(object sender, EventArgs e) => TextBox_Enter_Clear(sender, e);
        private void txt10_Enter(object sender, EventArgs e) => TextBox_Enter_Clear(sender, e);
        private void txt5_Enter(object sender, EventArgs e) => TextBox_Enter_Clear(sender, e);
        private void txt1_Enter(object sender, EventArgs e) => TextBox_Enter_Clear(sender, e);

        // ✅ Dummy handlers for Designer references (prevents errors)
        private void label6_Click(object sender, EventArgs e) { }
        private void UC_Deposit_Admin_Enter(object sender, EventArgs e) { }
    }
}
