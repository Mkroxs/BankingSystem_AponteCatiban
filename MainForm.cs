using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Models;

namespace BankingSystem_AponteCatiban
{
    public partial class MainForm : Form
    {
        public UC_Login login = new UC_Login();
        public UC_Dashboard_Admin dashboard_Admin = new UC_Dashboard_Admin();
        public UC_Dashboard_Cus dashboard_Cus = new UC_Dashboard_Cus();
        public UC_Deposit_Admin deposit_Admin = new UC_Deposit_Admin();
        public UC_Deposit_Cus deposit_customer = new UC_Deposit_Cus();
        public UC_Registration registration = new UC_Registration();
        public UC_CheckBalance_Admin checkBalance_Admin = new UC_CheckBalance_Admin();
        public UC_CheckBalance_Cus checkBalance_Cus = new UC_CheckBalance_Cus();
        public UC_CustomerProfile customerProfile = new UC_CustomerProfile();
        public UC_Profile profile = new UC_Profile();
        public UC_TransactionHistory transactionHistory = new UC_TransactionHistory();
        public UC_Withdraw withdraw = new UC_Withdraw();
        public UC_InitialDeposit initialDeposit = new UC_InitialDeposit();

        public Customer LoggedInCustomer { get; set; }
        public MainForm()
        {
            InitializeComponent();

            this.Controls.Add(login);
            this.Controls.Add(dashboard_Admin);
            this.Controls.Add(dashboard_Cus);
            this.Controls.Add(deposit_Admin);
            this.Controls.Add(deposit_customer);
            this.Controls.Add(registration);
            this.Controls.Add(checkBalance_Admin);
            this.Controls.Add(checkBalance_Cus);
            this.Controls.Add(customerProfile);
            this.Controls.Add(profile);
            this.Controls.Add(transactionHistory);
            this.Controls.Add(withdraw);
            this.Controls.Add(initialDeposit);

            login.Dock = DockStyle.Fill;
            dashboard_Admin.Dock = DockStyle.Fill;
            dashboard_Cus.Dock = DockStyle.Fill;
            deposit_Admin.Dock = DockStyle.Fill;
            deposit_customer.Dock = DockStyle.Fill;
            registration.Dock = DockStyle.Fill;
            checkBalance_Admin.Dock = DockStyle.Fill;
            checkBalance_Cus.Dock = DockStyle.Fill;
            customerProfile.Dock = DockStyle.Fill;
            profile.Dock = DockStyle.Fill;
            transactionHistory.Dock = DockStyle.Fill;
            withdraw.Dock = DockStyle.Fill;
            initialDeposit.Dock = DockStyle.Fill;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            login.BringToFront();
        }
    }
}
