using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem_AponteCatiban
{
    public partial class MainForm : Form
    {
        public UC_Dashboard_Admin dashboard_Admin = new UC_Dashboard_Admin();
        public UC_Dashboard_Cus dashboard_Cus = new UC_Dashboard_Cus();
        public UC_Deposit_Admin deposit_Admin = new UC_Deposit_Admin();
        public UC_Deposit_Cus deposit_customer = new UC_Deposit_Cus();
        public UC_Registration registration = new UC_Registration();

        public MainForm()
        {
            InitializeComponent();

            this.Controls.Add(dashboard_Admin);
            this.Controls.Add(dashboard_Cus);
            this.Controls.Add(deposit_Admin);
            this.Controls.Add(deposit_customer);
            this.Controls.Add(registration);

            dashboard_Admin.Dock = DockStyle.Fill;
            dashboard_Cus.Dock = DockStyle.Fill;
            deposit_Admin.Dock = DockStyle.Fill;
            deposit_customer.Dock = DockStyle.Fill;
            registration.Dock = DockStyle.Fill;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbxuser.Text == "admin" && txtbxpass.Text == "admin")
            {
                dashboard_Admin.BringToFront();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            registration.BringToFront();
        }
    }
}
