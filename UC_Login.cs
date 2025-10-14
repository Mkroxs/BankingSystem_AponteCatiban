using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;
using Newtonsoft.Json;
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
        public void RefreshCustomerData()
        {
            
            var refreshedCustomers = DataStore.LoadCustomers();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            string filePath = Path.Combine(Application.StartupPath, "Data", "customers.txt");

            string username = txtbxuser.Text.Trim();
            string password = txtbxpass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mainform = this.FindForm() as MainForm;

            // --- ADMIN LOGIN ---
            if (username == "admin" && password == "admin")
            {
                if (mainform != null)
                {
                    mainform.registration.btn_cancel.Visible = false;
                    mainform.lblTitleChildForm.Text = "Welcome!";

                    mainform.ClearCurrentUC();

                    mainform.panelDesktop.Controls.Add(mainform.login);
                    mainform.panelDesktop.Controls.Add(mainform.registration);

                    this.Hide();
                    mainform.ShowAdminPanel();
                    mainform.registration.panelTitle.Visible = false;
                }

                clearField();
                return;
            }

          
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Customer data file not found.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string jsonContent = File.ReadAllText(filePath);
                List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(jsonContent) ?? new List<Customer>();

                Customer matchingCustomer = customers.FirstOrDefault(c =>
                    string.Equals(c.Email?.Trim(), username, StringComparison.OrdinalIgnoreCase) &&
                    c.AccountNumber.Replace("-", "") == password);

                if (matchingCustomer != null)
                {
                    if (mainform != null)
                    {
                        mainform.LoggedInCustomer = matchingCustomer;
                        this.Hide();
                        mainform.ShowCustomerPanel();
                        mainform.lblTitleChildForm.Text = "Welcome!";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading customers data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clearField();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            Application.Exit();
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            var mainform = this.FindForm() as MainForm;
            if (mainform != null)
            {
                this.Hide();

                mainform.panelDesktop.Show();
                mainform.registration.Dock = DockStyle.Fill;

                if (!mainform.panelDesktop.Controls.Contains(mainform.registration))
                {
                    mainform.panelDesktop.Controls.Add(mainform.registration);
                }

                mainform.panelMenu.Hide();
                mainform.panelCustomer.Hide();
                mainform.panelTitleBar.Hide();

                mainform.registration.panelTitle.Visible = true;
                mainform.registration.BringToFront();
                mainform.registration.Show();

                mainform.lblTitleChildForm.Text = "Register Account";
            }
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

        private void UC_Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
