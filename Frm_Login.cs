using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Models;
using Newtonsoft.Json;

namespace BankingSystem_AponteCatiban
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void clearField()
        {
            txtbxuser.Text = string.Empty;
            txtbxpass.Text = string.Empty;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "Data", "customers.txt");

            string username = txtbxuser.Text.Trim();
            string password = txtbxpass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create or find MainForm
            MainForm mainform = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainform == null)
            {
                mainform = new MainForm();
            }

            // Admin Login
            if (username == "admin" && password == "admin")
            {
                mainform.lblTitleChildForm.Text = "Welcome!";
                mainform.ClearCurrentUC();
                mainform.panelDesktop.Controls.Clear();

                this.Hide();
                mainform.ShowAdminPanel();

                clearField();
                mainform.registration.panelTitle.Visible = false;
                mainform.Show();
                return;
            }

            // Customer Login
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Customers data file not found.", "Data Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearField();
                    return;
                }

                string jsonContent = File.ReadAllText(filePath);
                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(jsonContent)
                                           ?? new List<Customer>();

                Customer matchingCustomer = customers.FirstOrDefault(c =>
                    string.Equals(c.Email?.Trim(), username, StringComparison.OrdinalIgnoreCase) &&
                    (c.AccountNumber?.Replace("-", "") == password));

                if (matchingCustomer != null)
                {
                    mainform.LoggedInCustomer = matchingCustomer;
                    this.Hide();
                    mainform.ShowCustomerPanel();
                    mainform.lblTitleChildForm.Text = "Welcome!";
                    mainform.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Access Denied",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading customers data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clearField();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            Frm_Registration regForm = new Frm_Registration();
            regForm.Show();
            this.Hide();
        }

        private void lbl_Register_MouseEnter(object sender, EventArgs e)
        {
            lbl_Register.ForeColor = Color.LightCyan;
        }

        private void lbl_Register_MouseLeave(object sender, EventArgs e)
        {
            lbl_Register.ForeColor = Color.DodgerBlue;
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            clearField();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
