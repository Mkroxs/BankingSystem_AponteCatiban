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

        private decimal depositTotal = 0;


        
        public UC_Deposit_Cus()
        {
            InitializeComponent();
            
            this.Load += UC_Deposit_Cus_Load;

        }

        private void UC_Deposit_Cus_Load(object sender, EventArgs e)
        {
            

           
        }

        

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

        private void ClearDenominations()
        {
            txt1000.Text = "";
            txt500.Text = "";
            txt200.Text = "";
            txt100.Text = "";
            txt50.Text = "";
            txt20.Text = "";
            txt10.Text = "";
            txt5.Text = "";
            txt1.Text = "";
            depositTotal = 0;
            lbl_totalamount.Text = "₱0.00";
        }

        

        private void lbl_totalamount_Click(object sender, EventArgs e)
        {

        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            if (depositTotal <= 0)
            {
                MessageBox.Show("Please select a deposit amount.", "No Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mainform = this.FindForm() as MainForm;
            var customer = mainform?.LoggedInCustomer;

            if (customer == null)
            {
                MessageBox.Show("No logged-in customer found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal previousBalance = customer.Balance;
            customer.Balance += depositTotal;
            DataStore.UpdateCustomerBalance(customer.AccountNumber, customer.Balance);

            Transaction transaction = new Transaction
            {
                customerAccountNumber = customer.AccountNumber,
                type = "Deposit",
                amount = depositTotal,
                previousBalance = previousBalance,
                newBalance = customer.Balance,
                date = DateTime.Now.ToString("MMMM dd, yyyy")
            };
            DataStore.AppendTransaction(transaction);

            MessageBox.Show(
                $"Deposit Successful!\nAmount: ₱{depositTotal:N2}\nNew Balance: ₱{customer.Balance:N2}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mainform.LoggedInCustomer = customer;

            if (mainform.deposit_Admin != null)
                mainform.deposit_Admin.RefreshCustomerList();

            if (mainform.withdraw != null)
                mainform.withdraw.RefreshCustomerList();

            if (mainform.checkBalance_Admin != null)
            {
                mainform.checkBalance_Admin.LoadCustomers();
                mainform.checkBalance_Admin.SetupAccountNumberAutocomplete();
            }

            ClearDenominations();
        }
        


        

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearDenominations();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            mainform.dashboard_Cus.BringToFront();
        }
      
        

        private void btn_1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt1000_TextChanged(object sender, EventArgs e)
        {
            CalculateDepositTotal();
        }

        private void txt1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txt1000_Enter(object sender, EventArgs e)
        {
            (sender as TextBox)?.Clear();
        }

        private void txt500_Enter(object sender, EventArgs e)
        {
            (sender as TextBox)?.Clear();
        }

        private void txt500_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txt500_TextChanged(object sender, EventArgs e)
        {
            CalculateDepositTotal();
        }

        private void txt200_TextChanged(object sender, EventArgs e)
        {
            CalculateDepositTotal();
        }

        private void txt200_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txt200_Enter(object sender, EventArgs e)
        {
            (sender as TextBox)?.Clear();
        }

        private void txt100_TextChanged(object sender, EventArgs e)
        {
            CalculateDepositTotal();
        }

        private void txt100_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txt100_Enter(object sender, EventArgs e)
        {
            (sender as TextBox)?.Clear();
        }

        private void txt50_TextChanged(object sender, EventArgs e)
        {
            CalculateDepositTotal();
        }

        private void txt50_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void txt50_Enter(object sender, EventArgs e)
        {
            (sender as TextBox)?.Clear();
        }

        private void txt20_TextChanged(object sender, EventArgs e)
        {
            CalculateDepositTotal();
        }

        private void txt20_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void txt20_Enter(object sender, EventArgs e)
        {
            (sender as TextBox)?.Clear();

        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {
            CalculateDepositTotal();

        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void txt10_Enter(object sender, EventArgs e)
        {
            (sender as TextBox)?.Clear();

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            CalculateDepositTotal();
        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void txt5_Enter(object sender, EventArgs e)
        {
            (sender as TextBox)?.Clear();

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            CalculateDepositTotal();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);

        }

        private void txt1_Enter(object sender, EventArgs e)
        {
            (sender as TextBox)?.Clear();

        }

        private void UC_Deposit_Cus_Load_1(object sender, EventArgs e)
        {

        }
    }
}
