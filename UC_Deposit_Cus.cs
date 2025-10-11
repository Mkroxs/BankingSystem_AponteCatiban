using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Models;
using BankingSystem_AponteCatiban.Helpers;
using System.IO;
using Newtonsoft.Json;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Deposit_Cus: UserControl
    {

        decimal totalAmount = 0;

        private void setValue(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            if (decimal.TryParse(btn.Text.Replace("₱", ""), out decimal value))
            {
                totalAmount += value;
                lbl_totalamount.Text = $"₱{totalAmount:N2}";
            }
        }
        public UC_Deposit_Cus()
        {
            InitializeComponent();

            btn_1000.Click += setValue;
            btn_500.Click += setValue;
            btn_200.Click += setValue;
            btn_100.Click += setValue;
            btn_50.Click += setValue;
            btn_20.Click += setValue;
            btn_10.Click += setValue;
            btn_5.Click += setValue;
            btn_1.Click += setValue;
        }
        

        private void btn_1000_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_totalamount_Click(object sender, EventArgs e)
        {

        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            if (totalAmount <= 0)
            {
                MessageBox.Show("Please enter or select a valid amount to deposit.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mainform = this.FindForm() as MainForm;
            if (mainform == null || mainform.LoggedInCustomer == null)
            {
                MessageBox.Show("No logged-in customer found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string customerFile = Path.Combine(Application.StartupPath, "Data", "customers.txt");
                string transactionFile = Path.Combine(Application.StartupPath, "Data", "Transaction.txt");

                string customerJson = File.ReadAllText(customerFile);
                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(customerJson) ?? new List<Customer>();

                var customer = customers.FirstOrDefault(c => c.AccountNumber == mainform.LoggedInCustomer.AccountNumber);
                if (customer == null)
                {
                    MessageBox.Show("Customer record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal previousBalance = customer.Balance;
                customer.Balance += totalAmount;
                DataStore.UpdateCustomerBalance(customer.AccountNumber, customer.Balance);

            Transaction transaction = new Transaction
            {
                customerAccountNumber = customer.AccountNumber,
                type = "Deposit",
                amount = totalAmount,
                previousBalance = previousBalance,
                newBalance = customer.Balance,
                date = DateTime.Now.ToString("MMMM dd, yyyy")
            };
            DataStore.AppendTransaction(transaction);

                mainform.LoggedInCustomer = customer;

                MessageBox.Show($"Successfully deposited ₱{totalAmount:N2}.\nYour new balance is ₱{customer.Balance:N2}.",
                    "Deposit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetDepositForm();
                mainform.dashboard_Cus.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while processing deposit: " + ex.Message);
            }
        }
        private void ResetDepositForm()
        {
            totalAmount = 0;
            lbl_totalamount.Text = "₱0.00";
        }


        private void UC_Deposit_Cus_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            totalAmount = 0;
            lbl_totalamount.Text = "₱0.00";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            mainform.dashboard_Cus.BringToFront();
        }
      
        private void btn_500_Click(object sender, EventArgs e)
        {
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
        }

        private void btn_100_Click(object sender, EventArgs e)
        {
        }

        private void btn_50_Click(object sender, EventArgs e)
        {
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
