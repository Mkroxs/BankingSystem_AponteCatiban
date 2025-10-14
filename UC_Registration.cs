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

        public event Action<decimal> OnConfirm;

        public UC_Registration()
        {
            InitializeComponent();

            
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-200);

            
            SetupTextbox(txt1000);
            SetupTextbox(txt500);
            SetupTextbox(txt200);
            SetupTextbox(txt100);
            SetupTextbox(txt50);
            SetupTextbox(txt20);
            SetupTextbox(txt10);
            SetupTextbox(txt5);
            SetupTextbox(txt1);
        }

        private void SetupTextbox(TextBox txt)
        {
            if (txt == null) return;

            txt.KeyPress += (s, e) =>
            {
                if (char.IsControl(e.KeyChar)) return;

                
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    return;
                }

                
                if (txt.Text.Length >= 6)
                {
                    e.Handled = true;
                }
            };

            
            txt.Click += (s, e) => txt.Clear();

           
            txt.TextChanged += (s, e) => CalculateDepositTotal();
        }

        private void CalculateDepositTotal()
        {
            decimal total = 0;
            total += ParseInt(txt1000.Text) * 1000;
            total += ParseInt(txt500.Text) * 500;
            total += ParseInt(txt200.Text) * 200;
            total += ParseInt(txt100.Text) * 100;
            total += ParseInt(txt50.Text) * 50;
            total += ParseInt(txt20.Text) * 20;
            total += ParseInt(txt10.Text) * 10;
            total += ParseInt(txt5.Text) * 5;
            total += ParseInt(txt1.Text) * 1;

            initialValue = total;
            lbl_totalamount.Text = $"₱{total:N2}";
        }

        private int ParseInt(string text)
        {
            if (int.TryParse(text, out int value)) return value;
            return 0;
        }

        private void ClearFields()
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

            txt1000.Clear();
            txt500.Clear();
            txt200.Clear();
            txt100.Clear();
            txt50.Clear();
            txt20.Clear();
            txt10.Clear();
            txt5.Clear();
            txt1.Clear();

            lbl_totalamount.Text = "₱0.00";
            initialValue = 0;
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txtbx_name.Text.Trim();
                if (string.IsNullOrWhiteSpace(fullName) || !fullName.Contains(" "))
                {
                    MessageBox.Show("Please enter the customer's full name", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string gender = rbtn_male.Checked ? "Male" : rbtn_female.Checked ? "Female" : "";
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Please select a gender.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime birthdate = dateTimePicker1.Value;
                int age = DateTime.Now.Year - birthdate.Year;
                if (birthdate > DateTime.Now.AddYears(-age)) age--;
                if (birthdate > DateTime.Now || age <= 0)
                {
                    MessageBox.Show("Birthdate cannot be 0 years old", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbx_address.Text))
                {
                    MessageBox.Show("Please enter an address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string contact = txtbx_cnum.Text.Trim();
                if (!Regex.IsMatch(contact, @"^09\d{9}$"))
                {
                    MessageBox.Show("Contact number must be 11 digits and start with '09'.", "Invalid Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbx_civilstatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a civil status.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

                if (initialValue < 500)
                {
                    MessageBox.Show("Initial deposit must be at least ₱500.00.", "Insufficient Deposit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(selectedImagePath) || !File.Exists(selectedImagePath))
                {
                    MessageBox.Show("Please upload a profile picture.", "Missing Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

                var mainform = this.FindForm() as MainForm;
                if (mainform != null)
                {
                    
                    mainform.deposit_Admin.RefreshCustomerList();
                    mainform.withdraw.RefreshCustomerList();
                    mainform.checkBalance_Admin?.SetupAccountNumberAutocomplete();
                    mainform.login?.RefreshCustomerData();

                    Transaction transaction = new Transaction
                    {
                        customerAccountNumber = accountNumber,
                        type = "Deposit",
                        amount = initialValue,
                        previousBalance = 0,
                        newBalance = initialValue,
                        date = DateTime.Now.ToString("MMMM dd, yyyy")
                    };
                    DataStore.AppendTransaction(transaction);

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

        
        private void UC_Registration_Load(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void txtbx_name_TextChanged(object sender, EventArgs e) { }
        private void txtbx_address_TextChanged(object sender, EventArgs e) { }

        private void txt1000_KeyPress(object sender, KeyPressEventArgs e) { }
        private void txt500_KeyPress(object sender, KeyPressEventArgs e) { }
        private void txt200_KeyPress(object sender, KeyPressEventArgs e) { }
        private void txt100_KeyPress(object sender, KeyPressEventArgs e) { }
        private void txt50_KeyPress(object sender, KeyPressEventArgs e) { }
        private void txt20_KeyPress(object sender, KeyPressEventArgs e) { }
        private void txt10_KeyPress(object sender, KeyPressEventArgs e) { }
        private void txt5_KeyPress(object sender, KeyPressEventArgs e) { }
        private void txt1_KeyPress(object sender, KeyPressEventArgs e) { }

        private void txt1000_TextChanged(object sender, EventArgs e) { }
        private void txt500_TextChanged(object sender, EventArgs e) { }
        private void txt200_TextChanged(object sender, EventArgs e) { }
        private void txt100_TextChanged(object sender, EventArgs e) { }
        private void txt50_TextChanged(object sender, EventArgs e) { }
        private void txt20_TextChanged(object sender, EventArgs e) { }
        private void txt10_TextChanged(object sender, EventArgs e) { }
        private void txt5_TextChanged(object sender, EventArgs e) { }
        private void txt1_TextChanged(object sender, EventArgs e) { }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
