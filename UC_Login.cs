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
            string username = txtbxuser.Text.Trim();
            string password = txtbxpass.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (username == "admin" && password == "admin")
            {
                var mainform = this.Parent as MainForm;
                if (mainform != null)
                {
                    mainform.dashboard_Admin.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
