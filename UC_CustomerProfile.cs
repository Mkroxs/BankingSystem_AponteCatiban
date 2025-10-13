using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_CustomerProfile: UserControl
    {
        public UC_CustomerProfile()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void UC_CustomerProfile_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
            clearField();
        }

        public bool LoadCustomerData(bool showMessageIfEmpty = false)
        {
            try
            {
                List<Customer> customers = DataStore.LoadCustomers();

                if (customers.Count == 0)
                {
                    if (showMessageIfEmpty)
                        MessageBox.Show("No Registered Customers Found");
                    dgv_cuslist.DataSource = null;
                    return false; 
                }

                dgv_cuslist.DataSource = customers;

                dgv_cuslist.Columns["ImagePath"].Visible = false;
                dgv_cuslist.Columns["Birthdate"].DefaultCellStyle.Format = "yyyy-MM-dd";

                return true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers:\n" + ex.Message);
                return false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            

            if (dgv_cuslist.SelectedRows.Count > 0)
            {
                dgv_cuslist.ClearSelection();
            }
            clearField();
        }

        private void clearField()
        {
            lbl_cusid.Text = null;
            lbl_accnum.Text = null;
            lbl_name.Text = null;
            lbl_gender.Text = null;
            lbl_bdate.Text = null;
            lbl_address.Text = null;
            lbl_cnum.Text = null;
            lbl_eaddress.Text = null;
            lbl_civilstatus.Text = null;
            pictureBox1.Image = null;
        }

        private void dgv_cuslist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return; 

                DataGridViewRow row = dgv_cuslist.Rows[e.RowIndex];

               
                lbl_cusid.Text = row.Cells["CustomerId"].Value?.ToString();
                lbl_accnum.Text = row.Cells["AccountNumber"].Value?.ToString();
                lbl_name.Text = row.Cells["FullName"].Value?.ToString();
                lbl_gender.Text = row.Cells["Gender"].Value?.ToString();
                lbl_bdate.Text = Convert.ToDateTime(row.Cells["Birthdate"].Value).ToString("yyyy-MM-dd");
                lbl_address.Text = row.Cells["Address"].Value?.ToString();
                lbl_cnum.Text = row.Cells["Contact"].Value?.ToString();
                lbl_eaddress.Text = row.Cells["Email"].Value?.ToString();
                lbl_civilstatus.Text = row.Cells["CivilStatus"].Value?.ToString();
                

               
                string imagePath = row.Cells["ImagePath"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying selected customer:\n" + ex.Message);
            }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_eaddress_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cusid_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
