using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-200);
        }
        private void ClearFields()
        {
            txtbx_name.Clear();
            rbtn_male.Checked = false;
            rbtn_female.Checked = false;
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
            txtbx_address.Clear();
            txtbx_cnum.Clear();
            txtbx_eaddress.Clear();
            cbx_civilstatus.SelectedIndex = -1;
            btn_InitialDeposit.Text = "Enter Value";
            pbx_profile.Image = null;
            selectedImagePath = "";
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            if (mainform == null) return;

            mainform.initialDeposit.Visible = true;
            mainform.initialDeposit.BringToFront();

            mainform.initialDeposit.OnConfirm += (total) =>
            {
                btn_InitialDeposit.Text = total.ToString();
                mainform.initialDeposit.Visible = false;
            };

            mainform.initialDeposit.lbl_totalamount.Text = btn_InitialDeposit.Text;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            try
            {

                string fullName = txtbx_name.Text.Trim();
                if (string.IsNullOrWhiteSpace(fullName))
                {
                    MessageBox.Show("Please enter the customer's full name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string gender = "";
                if (rbtn_male.Checked)
                    gender = "Male";
                else if (rbtn_female.Checked)
                    gender = "Female";
                else
                {
                    MessageBox.Show("Please select a gender.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                DateTime birthdate = dateTimePicker1.Value;
                int age = DateTime.Now.Year - birthdate.Year;
                if (birthdate > DateTime.Now || age <= 0)
                {
                    MessageBox.Show("Birthdate cannot be 0 years old.", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string address = txtbx_address.Text.Trim();
                if (string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Please enter the customer's address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string contact = txtbx_cnum.Text.Trim();
                if (string.IsNullOrWhiteSpace(contact))
                {
                    MessageBox.Show("Please enter a contact number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string civilStatus = cbx_civilstatus.Text.Trim();
                if (string.IsNullOrWhiteSpace(civilStatus))
                {
                    MessageBox.Show("Please select a civil status.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string email = txtbx_eaddress.Text.Trim();
                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please enter an email address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                    if (!Regex.IsMatch(email, emailPattern))
                    {
                        MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                decimal initialDeposit = 0;
                if (!decimal.TryParse(btn_InitialDeposit.Text, out initialDeposit))
                {
                    MessageBox.Show("Please enter a valid initial deposit amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (initialDeposit < 500)
                {
                    MessageBox.Show("Initial deposit must be at least ₱500.00.", "Insufficient Deposit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (string.IsNullOrEmpty(selectedImagePath) || !File.Exists(selectedImagePath))
                {
                    MessageBox.Show("Please upload a profile picture before proceeding.", "Missing Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                var customers = DataStore.LoadCustomers();
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
                    Address = address,
                    Contact = contact,
                    Email = email,
                    CivilStatus = civilStatus,
                    Balance = initialDeposit,
                    ImagePath = selectedImagePath
                };


                customers.Add(newCustomer);
                DataStore.SaveCustomers(customers);

                var mainform = this.Parent as MainForm;

                mainform.deposit_Admin.RefreshCustomerList();
                mainform.withdraw.RefreshCustomerList();


                Transaction transaction = new Transaction
                {
                    customerAccountNumber = accountNumber,
                    type = "Deposit",
                    amount = initialDeposit,
                    previousBalance = 0,
                    newBalance = initialDeposit,
                    date = DateTime.Now.ToString("MMMM dd, yyyy")
                };
                DataStore.AppendTransaction(transaction);

                MessageBox.Show($"Registration Successful!\n\nCustomer ID: {customerId}\nAccount Number: {accountNumber}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration:\n" + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Select Customer Profile Picture";
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {

                        pbx_profile.Image = Image.FromFile(ofd.FileName);


                        string imageFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images");
                        Directory.CreateDirectory(imageFolder);


                        string fileName = Path.GetFileName(ofd.FileName);
                        string destPath = Path.Combine(imageFolder, fileName);


                        if (File.Exists(destPath))
                        {
                            string uniqueName = Path.GetFileNameWithoutExtension(fileName)
                                + "_" + DateTime.Now.ToString("yyyyMMdd")
                                + Path.GetExtension(fileName);
                            destPath = Path.Combine(imageFolder, uniqueName);
                        }

                        File.Copy(ofd.FileName, destPath, true);


                        selectedImagePath = destPath;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading image:\n" + ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }

        private void txtbx_cnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtbx_cnum.Text;

            
            if (char.IsControl(e.KeyChar))
                return;

            
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            
            if (text.Length == 0 && e.KeyChar != '0')
            {
                e.Handled = true;
                return;
            }

            
            if (text.Length >= 11)
            {
                e.Handled = true;
                return;
            }
        }

        private void txtbx_cnum_TextChanged(object sender, EventArgs e)
        {
            string text = txtbx_cnum.Text;


            if (text.Length > 11)
            {
                txtbx_cnum.Text = text.Substring(0, 11);
                txtbx_cnum.SelectionStart = txtbx_cnum.Text.Length;
            }


            if (!string.IsNullOrEmpty(text) && text[0] != '0')
            {
                MessageBox.Show("Contact number must start with 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbx_cnum.Text = "";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}