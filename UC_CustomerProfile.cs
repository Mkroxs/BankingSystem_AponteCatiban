using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_CustomerProfile : UserControl
    {
        public UC_CustomerProfile()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Enable responsive scaling
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void UC_CustomerProfile_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
            StyleDataGridView();
            clearField();
        }

        // ✅ Loads all customers into DataGridView
        public bool LoadCustomerData(bool showMessageIfEmpty = false)
        {
            try
            {
                List<Customer> customers = DataStore.LoadCustomers();

                if (customers == null || customers.Count == 0)
                {
                    if (showMessageIfEmpty)
                        MessageBox.Show("No Registered Customers Found.", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgv_cuslist.DataSource = null;
                    return false;
                }

                dgv_cuslist.DataSource = customers;

                // Hide unnecessary columns
                dgv_cuslist.Columns["ImagePath"].Visible = false;
                if (dgv_cuslist.Columns.Contains("Balance"))
                    dgv_cuslist.Columns["Balance"].Visible = false; // ❌ hide balance

                // Format date
                dgv_cuslist.Columns["Birthdate"].DefaultCellStyle.Format = "yyyy-MM-dd";

                // Rename headers for clarity
                dgv_cuslist.Columns["CustomerId"].HeaderText = "Customer ID";
                dgv_cuslist.Columns["AccountNumber"].HeaderText = "Account Number";
                dgv_cuslist.Columns["FullName"].HeaderText = "Full Name";
                dgv_cuslist.Columns["Gender"].HeaderText = "Gender";
                dgv_cuslist.Columns["Birthdate"].HeaderText = "Birth Date";
                dgv_cuslist.Columns["Address"].HeaderText = "Address";
                dgv_cuslist.Columns["Contact"].HeaderText = "Contact Number";
                dgv_cuslist.Columns["Email"].HeaderText = "Email Address";
                dgv_cuslist.Columns["CivilStatus"].HeaderText = "Civil Status";

                // 🧭 Lock editing — make grid read-only
                dgv_cuslist.ReadOnly = true;
                dgv_cuslist.AllowUserToAddRows = false;
                dgv_cuslist.AllowUserToDeleteRows = false;
                dgv_cuslist.AllowUserToResizeRows = false;
                dgv_cuslist.RowHeadersVisible = false;
                dgv_cuslist.MultiSelect = false;
                dgv_cuslist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Apply styling
                dgv_cuslist.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgv_cuslist.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                dgv_cuslist.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgv_cuslist.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_cuslist.EnableHeadersVisualStyles = false;

                dgv_cuslist.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dgv_cuslist.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dgv_cuslist.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgv_cuslist.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                dgv_cuslist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_cuslist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgv_cuslist.RowTemplate.Height = 28;
                dgv_cuslist.BackgroundColor = Color.White;
                dgv_cuslist.GridColor = Color.LightGray;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void StyleDataGridView()
        {
            dgv_cuslist.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_cuslist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_cuslist.MultiSelect = false;
            dgv_cuslist.BackgroundColor = Color.White;
            dgv_cuslist.GridColor = Color.LightGray;
            dgv_cuslist.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv_cuslist.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (dgv_cuslist.SelectedRows.Count > 0)
            {
                dgv_cuslist.ClearSelection();
            }
            clearField();
        }

        private void clearField()
        {
            lbl_cusid.Text = "—";
            lbl_accnum.Text = "—";
            lbl_name.Text = "—";
            lbl_gender.Text = "—";
            lbl_bdate.Text = "—";
            lblage.Text = "—";
            lbl_address.Text = "—";
            lbl_cnum.Text = "—";
            lbl_eaddress.Text = "—";
            lbl_civilstatus.Text = "—";
            pictureBox1.Image = null;
        }

        private void dgv_cuslist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                DataGridViewRow row = dgv_cuslist.Rows[e.RowIndex];

                lbl_cusid.Text = row.Cells["CustomerId"].Value?.ToString() ?? "—";
                lbl_accnum.Text = row.Cells["AccountNumber"].Value?.ToString() ?? "—";
                lbl_name.Text = row.Cells["FullName"].Value?.ToString() ?? "—";
                lbl_gender.Text = row.Cells["Gender"].Value?.ToString() ?? "—";
                lbl_bdate.Text = Convert.ToDateTime(row.Cells["Birthdate"].Value).ToString("yyyy-MM-dd");
                lbl_address.Text = row.Cells["Address"].Value?.ToString() ?? "—";
                lbl_cnum.Text = row.Cells["Contact"].Value?.ToString() ?? "—";
                lbl_eaddress.Text = row.Cells["Email"].Value?.ToString() ?? "—";
                lbl_civilstatus.Text = row.Cells["CivilStatus"].Value?.ToString() ?? "—";

                DateTime birthDate = Convert.ToDateTime(row.Cells["Birthdate"].Value);
                int age = DateTime.Now.Year - birthDate.Year;
                if (birthDate > DateTime.Now.AddYears(-age)) age--;
                lblage.Text = age == 1 ? $"{age} year old" : $"{age} years old";

                string imagePath = row.Cells["ImagePath"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                    pictureBox1.Image = Image.FromFile(imagePath);
                else
                    pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying selected customer:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbl_name_Click(object sender, EventArgs e) { }
        private void lbl_eaddress_Click(object sender, EventArgs e) { }
        private void lbl_cusid_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
