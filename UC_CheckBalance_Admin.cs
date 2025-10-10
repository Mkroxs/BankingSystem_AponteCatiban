using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_CheckBalance_Admin: UserControl
    {
        public UC_CheckBalance_Admin()
        {
            InitializeComponent();
        }

        public bool LoadCustomerData(bool showMessageIfEmpty = false)
        {
            try
            {
                List<Customer> customers = DataStore.LoadCustomers();

                if (customers.Count == 0)
                {
                    dgvCustomers.DataSource = null;

                    if (showMessageIfEmpty)
                        MessageBox.Show("No Registered Customers Found.");

                    return false; 
                }

               
                var displayList = new List<object>();
                foreach (var c in customers)
                {
                    displayList.Add(new
                    {
                        AccountNumber = c.AccountNumber,
                        AccountName = c.FullName,
                        RemainingBalance = c.Balance
                    });
                }

                dgvCustomers.DataSource = displayList;

               
                dgvCustomers.Columns["RemainingBalance"].DefaultCellStyle.Format = "₱0.00";

                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers:\n" + ex.Message);
                return false;
            }
        }

        private void UC_CheckBalance_Admin_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvCustomers.Rows[e.RowIndex];
            lbl_accnum.Text = row.Cells["AccountNumber"].Value?.ToString();
            lbl_accname.Text = row.Cells["AccountName"].Value?.ToString();
            lbl_rembal.Text = $"₱{row.Cells["RemainingBalance"].Value:N2}";
        }

        private void lbl_accnum_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_accname_Click(object sender, EventArgs e)
        {

        }

        private void lbl_rembal_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.dashboard_Admin.BringToFront();
        }
    }
}
