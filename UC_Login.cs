using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Models;
using Newtonsoft.Json;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        private void clearField()
        {
            txtbxuser.Text = string.Empty;
            txtbxpass.Text = string.Empty;
        }

        private void txtbxuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
                
                string filePath = Path.Combine(Application.StartupPath, "Data", "customers.txt");

                string username = txtbxuser.Text.Trim();
                string password = txtbxpass.Text.Trim();
                try
                {
                    string jsonContent = File.ReadAllText(filePath);
                    List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(jsonContent);

                    Customer matchingCustomer = customers.FirstOrDefault(c =>
                        c.Email == username &&
                        c.AccountNumber.Replace("-", "") == password);

                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (username == "admin" && password == "admin")
                    {
                    var mainform = this.FindForm() as MainForm;
                    if (mainform != null)
                        {
                            mainform.dashboard_Admin.BringToFront();
                        }
                    }
                    else if (matchingCustomer != null)
                    {
                        var mainform = this.Parent as MainForm;
                        if (mainform != null)
                        {
                            mainform.LoggedInCustomer = matchingCustomer; 
                            mainform.dashboard_Cus.BringToFront();

                    }
                }
                else
                {
                        MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch { }


                    clearField();
            }

        private void btnclose_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Application.Exit();
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.registration.Show();
            mainform.registration.BringToFront();
            lbl_Register.ForeColor = Color.White;
            clearField();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Register_MouseEnter(object sender, EventArgs e)
        {
            lbl_Register.ForeColor = Color.LightCyan;

        }

        private void lbl_Register_MouseLeave(object sender, EventArgs e)
        {
            lbl_Register.ForeColor = Color.DodgerBlue;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
        "Are you sure you want to reset all customer and transaction data?\nThis action cannot be undone.",
        "Confirm Reset",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning) == DialogResult.No)
                return;

            try
            {
                string dataFolder = Path.Combine(Application.StartupPath, "Data");
                string customerFile = Path.Combine(dataFolder, "customers.txt");
                string transactionFile = Path.Combine(dataFolder, "transactions.txt");

                
                File.WriteAllText(customerFile, "[]", Encoding.UTF8);
                File.WriteAllText(transactionFile, "[]", Encoding.UTF8);

                
                var mainform = this.FindForm() as MainForm;
                if (mainform != null)
                {
                    mainform.deposit_Admin?.RefreshCustomerList();
                    mainform.withdraw?.RefreshCustomerList();
                    mainform.checkBalance_Admin?.LoadCustomers();
                }

                MessageBox.Show("All data in customers.txt and transactions.txt have been reset successfully.",
                                "Reset Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting data:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
