using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Registration : UserControl
    {
        public decimal initialValue = 0;
        private string selectedImagePath = "";

        public UC_Registration()
        {
            InitializeComponent();
            SetupInitialDepositTextbox();

            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-200);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void SetupInitialDepositTextbox()
        {
            tbxInitialDeposit.KeyPress += (s, e) =>
            {
                // Allow only digits and control keys
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }
            };

            tbxInitialDeposit.TextChanged += (s, e) =>
            {
                string text = tbxInitialDeposit.Text.Replace("₱", "").Replace(",", "").Trim();

                if (string.IsNullOrEmpty(text))
                {
                    tbxInitialDeposit.Text = "";
                    return;
                }

                if (decimal.TryParse(text, out decimal value))
                {
                    // Prevent overflow or negative
                    if (value > 9999999999M)
                    {
                        MessageBox.Show("Value too large. Please enter a smaller amount.",
                            "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbxInitialDeposit.Text = "₱9,999,999,999";
                        tbxInitialDeposit.SelectionStart = tbxInitialDeposit.Text.Length;
                        return;
                    }

                    // Format with peso and commas
                    tbxInitialDeposit.Text = $"₱{value:N0}";
                    tbxInitialDeposit.SelectionStart = tbxInitialDeposit.Text.Length;
                }
                else
                {
                    tbxInitialDeposit.Text = "";
                }
            };
        }

        public void ClearFields()
        {
            txtbx_name.Clear();
            txtbx_address.Clear();
            txtbx_cnum.Clear();
            txtbx_eaddress.Clear();
            cbx_civilstatus.SelectedIndex = -1;
            rbtn_male.Checked = false;
            rbtn_female.Checked = false;
            pbx_profile.Image = null;
            selectedImagePath = "";
            tbxInitialDeposit.Clear();
            initialValue = 0;
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            try
            {
                // FULL NAME VALIDATION
                string fullName = txtbx_name.Text.Trim();
                if (string.IsNullOrWhiteSpace(fullName) || !fullName.Contains(" "))
                {
                    MessageBox.Show("Please enter the customer's full name", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // GENDER VALIDATION
                string gender = rbtn_male.Checked ? "Male" : rbtn_female.Checked ? "Female" : "";
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Please select a gender.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // BIRTHDATE VALIDATION
                DateTime birthdate = dateTimePicker1.Value;
                int age = DateTime.Now.Year - birthdate.Year;
                if (birthdate > DateTime.Now.AddYears(-age)) age--;
                if (birthdate > DateTime.Now || age <= 0)
                {
                    MessageBox.Show("Birthdate cannot be 0 years old", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ADDRESS VALIDATION
                if (string.IsNullOrWhiteSpace(txtbx_address.Text))
                {
                    MessageBox.Show("Please enter an address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // CONTACT VALIDATION
                string contact = txtbx_cnum.Text.Trim();
                if (!Regex.IsMatch(contact, @"^09\d{9}$"))
                {
                    MessageBox.Show("Contact number must be 11 digits and start with '09'.", "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // CIVIL STATUS VALIDATION
                if (cbx_civilstatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a civil status.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // EMAIL VALIDATION
                string email = txtbx_eaddress.Text.Trim();
                string emailPattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
                if (!Regex.IsMatch(email, emailPattern))
                {
                    MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var customers = DataStore.LoadCustomers() ?? new List<Customer>();
                if (customers.Any(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("This email is already registered.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // INITIAL DEPOSIT VALIDATION (allow ₱ and commas)
                string cleaned = tbxInitialDeposit.Text.Replace("₱", "").Replace(",", "").Trim();
                if (!decimal.TryParse(cleaned, out decimal depositAmount) || depositAmount < 500)
                {
                    MessageBox.Show("Initial deposit must be a valid amount and at least ₱500.00.", "Invalid Deposit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // IMAGE VALIDATION
                if (string.IsNullOrEmpty(selectedImagePath) || !File.Exists(selectedImagePath))
                {
                    MessageBox.Show("Please upload a profile picture.", "Missing Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                initialValue = depositAmount;

                int sequence = customers.Count + 1;
                string customerId = IdGenerator.GenerateCustomerId(sequence);
                string accountNumber = IdGenerator.GenerateAccountNumber(birthdate, sequence);

                Customer newCustomer = new Customer
                {
                    CustomerId = customerId,
                    AccountNumber = accountNumber,
                    FullName = fullName,
                    Gender = gender,
                    Birthdate = birthdate,
                    Address = txtbx_address.Text.Trim(),
                    Contact = contact,
                    Email = email,
                    CivilStatus = cbx_civilstatus.Text.Trim(),
                    Balance = initialValue,
                    ImagePath = selectedImagePath
                };

                customers.Add(newCustomer);
                DataStore.SaveCustomers(customers);

                // INITIAL DEPOSIT TRANSACTION
                Transaction transaction = new Transaction
                {
                    customerAccountNumber = accountNumber,
                    type = "Initial Deposit",
                    amount = initialValue,
                    previousBalance = 0,
                    newBalance = initialValue,
                    date = DateTime.Now.ToString("MMMM dd, yyyy")
                };
                DataStore.AppendTransaction(transaction);

                var mainform = this.FindForm() as MainForm;
                if (mainform != null)
                {
                    mainform.deposit_Admin.RefreshCustomerList();
                    mainform.withdraw.RefreshCustomerList();
                    mainform.checkBalance_Admin?.SetupAccountNumberAutocomplete();
                    mainform.login?.RefreshCustomerData();

                    MessageBox.Show($"Registration Successful!\n\nCustomer ID: {customerId}\nAccount Number: {accountNumber}",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration:\n" + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    pbx_profile.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        private void txtbx_cnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (txt.Text.Length >= 11)
            {
                e.Handled = true;
                return;
            }

            if (txt.Text.Length == 0 && e.KeyChar != '0')
            {
                e.Handled = true;
                return;
            }

            if (txt.Text.Length == 1 && e.KeyChar != '9')
            {
                e.Handled = true;
                return;
            }
        }

        private void txtbx_cnum_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_cnum.Text.Length > 11)
                txtbx_cnum.Text = txtbx_cnum.Text.Substring(0, 11);
            txtbx_cnum.SelectionStart = txtbx_cnum.Text.Length;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            var mainform = this.FindForm() as MainForm;
            if (mainform != null)
            {
                if (!mainform.panelDesktop.Controls.Contains(mainform.login))
                    mainform.panelDesktop.Controls.Add(mainform.login);

                mainform.panelDesktop.Show();
                mainform.login.BringToFront();
                mainform.login.Show();

                mainform.panelMenu.Hide();
                mainform.panelCustomer.Hide();
                mainform.panelTitleBar.Hide();

                this.Hide();
            }
        }

        // ---- EMPTY EVENT HANDLERS ----
        private void UC_Registration_Load(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void txtbx_name_TextChanged(object sender, EventArgs e) { }
        private void txtbx_address_TextChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields() ;
        }
    }
}
