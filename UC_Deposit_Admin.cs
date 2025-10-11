using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;
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
    public partial class UC_Deposit_Admin: UserControl
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
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.dashboard_Admin.BringToFront();
            ClearCustomerDisplay();
            txt_accnum.Text = null;
            selectedCustomer = null;
        }

        private void UC_Deposit_Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void txt_accnum_TextChanged(object sender, EventArgs e)
        {

            string accNum = txt_accnum.Text.Trim();
            if (string.IsNullOrWhiteSpace(accNum))
            {
                
                ClearCustomerDisplay();
                return;
            }

            selectedCustomer = customers.FirstOrDefault(c => c.AccountNumber == accNum);
            if (selectedCustomer != null)
            {
                lbl_accname.Text = selectedCustomer.FullName;
                lbl_currbal.Text = $"₱{selectedCustomer.Balance:N2}";
            }
            else
            {
                
                ClearCustomerDisplay();
            }
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
                date = DateTime.Now
            };
            DataStore.AppendTransaction(transaction);

            MessageBox.Show(
                $"Deposit Successful!\n\nAccount: {selectedCustomer.AccountNumber}\nAmount: ₱{depositTotal:N2}\nNew Balance: ₱{selectedCustomer.Balance:N2}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var mainform = this.Parent as MainForm;
            mainform.withdraw.RefreshCustomerList();
            mainform.deposit_Admin.RefreshCustomerList();

            ClearCustomerDisplay();
            txt_accnum.Text = null;
            selectedCustomer = null;

        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            depositTotal = 0;
            lbl_totalamount.Text = "₱0.00";
        }
        private void AddDeposit(decimal amount)
        {
            depositTotal += amount;
            lbl_totalamount.Text = $"₱{depositTotal:N2}";
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            AddDeposit(1000);
        }

        private void btn_500_Click(object sender, EventArgs e)
        {
            AddDeposit(500);

        }

        private void btn_200_Click(object sender, EventArgs e)
        {
            AddDeposit(200);

        }

        private void btn_100_Click(object sender, EventArgs e)
        {
            AddDeposit(100);

        }

        private void btn_50_Click(object sender, EventArgs e)
        {
            AddDeposit(50);

        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            AddDeposit(20);

        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            AddDeposit(10);

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            AddDeposit(5);

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            AddDeposit(1);

        }
    }
}
