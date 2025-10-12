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
        private Timer sidebarTimer = new Timer();
        


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
            mainPanelSide.Visible = false;
            mainPanelCustomer.Visible = false;


        }

       

        

        private void lblregister_Click(object sender, EventArgs e)
        {
            registration.BringToFront();
            registration.Show();
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
            login.BringToFront();
            mainPanelSide.Visible = false;
        }

        private void mainPanelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbldeposit_Click(object sender, EventArgs e)
        {
            deposit_Admin.BringToFront();
            
        }

        private void lblwithdraw_Click(object sender, EventArgs e)
        {
            withdraw.BringToFront();
        }

        private void lblcheck_bal_Click(object sender, EventArgs e)
        {
            checkBalance_Admin.BringToFront();
            checkBalance_Admin.LoadCustomers();
            checkBalance_Admin.SetupAccountNumberAutocomplete();

        }

        private void lblcus_prof_Click(object sender, EventArgs e)
        {
            customerProfile.BringToFront();
            customerProfile.LoadCustomerData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            deposit_customer.BringToFront();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            checkBalance_Cus.LoadCustomerData();

            checkBalance_Cus.BringToFront();
        }

        private void lbltransac_history_Click(object sender, EventArgs e)
        {
            if (this != null)
            {
                transactionHistory.LoadTransactionHistory();
                transactionHistory.BringToFront();
            }
            
        }

        private void lblprof_Click(object sender, EventArgs e)
        {
            if (this != null)
            {
                profile.BringToFront();
                profile.LoadCustomerData();
            }
            
        }

        private void lblllogout_Click(object sender, EventArgs e)
        {
            login.BringToFront();
            mainPanelCustomer.Visible = false;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void menuButton_MouseClick(object sender, MouseEventArgs e)
        {
            sidebarTimer.Start();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            sidebarTimer.Start();
        }

        private void mainPanelCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblregister_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(0, 60, 85);

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(0, 60, 85);

        }

        private void lblregister_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(66, 125, 213);

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(66, 125, 213);

        }

        private void lblregister_MouseClick(object sender, MouseEventArgs e)
        {
            registration.BringToFront();
            registration.Show();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            registration.BringToFront();
            registration.Show();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            registration.BringToFront();
            registration.Show();
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void lbldeposit_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel5_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void lblwithdraw_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void lbldeposit_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void lblwithdraw_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            deposit_Admin.BringToFront();
            deposit_Admin.Show();
        }

        private void lbldeposit_MouseClick(object sender, MouseEventArgs e)
        {
            deposit_Admin.BringToFront();
            deposit_Admin.Show();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            deposit_Admin.BringToFront();
            deposit_Admin.Show();
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            withdraw.BringToFront();
            withdraw.Show();
        }

        private void lblwithdraw_MouseClick(object sender, MouseEventArgs e)
        {
            withdraw.BringToFront();
            withdraw.Show();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            withdraw.BringToFront();
            withdraw.Show();
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void lblcheck_bal_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void lblcheck_bal_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            checkBalance_Admin.BringToFront();
            checkBalance_Admin.Show();
        }

        private void lblcheck_bal_MouseClick(object sender, MouseEventArgs e)
        {
            checkBalance_Admin.BringToFront();
            checkBalance_Admin.Show();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            checkBalance_Admin.BringToFront();
            checkBalance_Admin.Show();
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void lblcus_prof_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void lblcus_prof_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            customerProfile.BringToFront();
            customerProfile.Show();
        }

        private void lblcus_prof_MouseClick(object sender, MouseEventArgs e)
        {
            customerProfile.BringToFront();
            customerProfile.Show();
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            customerProfile.BringToFront();
            customerProfile.Show();
        }

        private void panel8_MouseEnter(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void lbllogout_MouseEnter(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void lbllogout_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            login.BringToFront();
            mainPanelSide.Visible = false;
        }

        private void lbllogout_MouseClick(object sender, MouseEventArgs e)
        {
            login.BringToFront();
            mainPanelSide.Visible = false;
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            login.BringToFront();
            mainPanelSide.Visible = false;
        }

        private void panel9_MouseEnter(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            deposit_customer.BringToFront();
            deposit_customer.Show();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            deposit_customer.BringToFront();
            deposit_customer.Show();
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            deposit_customer.BringToFront();
            deposit_customer.Show();
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            checkBalance_Cus.LoadCustomerData();
            checkBalance_Cus.BringToFront();
            checkBalance_Cus.Show();
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            checkBalance_Cus.LoadCustomerData();
            checkBalance_Cus.BringToFront();
            checkBalance_Cus.Show();
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            checkBalance_Cus.LoadCustomerData();
            checkBalance_Cus.BringToFront();
            checkBalance_Cus.Show();
        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void lbltransac_history_MouseEnter(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void lbltransac_history_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            transactionHistory.BringToFront();
            transactionHistory.Show();
            transactionHistory.LoadTransactionHistory();
        }

        private void lbltransac_history_MouseClick(object sender, MouseEventArgs e)
        {
            transactionHistory.BringToFront();
            transactionHistory.Show();
            transactionHistory.LoadTransactionHistory();
        }

        private void pictureBox11_MouseClick(object sender, MouseEventArgs e)
        {
            transactionHistory.BringToFront();
            transactionHistory.Show();
            transactionHistory.LoadTransactionHistory();
        }

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void lblprof_MouseEnter(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void lblprof_MouseLeave(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            panel12.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel12_MouseClick(object sender, MouseEventArgs e)
        {
            profile.BringToFront();
            profile.Show();
            profile.LoadCustomerData();
        }

        private void lblprof_MouseClick(object sender, MouseEventArgs e)
        {
            profile.BringToFront();
            profile.Show();
            profile.LoadCustomerData();
        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            profile.BringToFront();
            profile.Show();
            profile.LoadCustomerData();
        }

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void lblllogout_MouseEnter(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(0, 60, 85);
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void lblllogout_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(66, 125, 213);
        }

        private void panel13_MouseClick(object sender, MouseEventArgs e)
        {
            login.BringToFront();
            mainPanelCustomer.Visible = false;
        }

        private void lblllogout_MouseClick(object sender, MouseEventArgs e)
        {
            login.BringToFront();
            mainPanelCustomer.Visible = false;
        }

        private void pictureBox9_MouseClick(object sender, MouseEventArgs e)
        {
            login.BringToFront();
            mainPanelCustomer.Visible = false;
        }
    }
}
