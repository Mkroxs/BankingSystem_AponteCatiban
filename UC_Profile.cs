using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Models;
using Newtonsoft.Json;
using System.IO;
using System.Drawing.Drawing2D;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Profile : UserControl
    {
        public UC_Profile()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void lbl_address_Click(object sender, EventArgs e)
        {
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
        }

        private void MakePictureBoxCircular()
        {
            try
            {
                if (pictureBox1.Width != pictureBox1.Height)
                {
                    int size = Math.Min(pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Size = new Size(size, size);
                }

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
                    pictureBox1.Region = new Region(path);
                }

                pictureBox1.Refresh();
            }
            catch { }
        }

        private void LoadCustomerImage(string ImagePath)
        {
            try
            {
                string fullImagePath = ImagePath;

                if (ImagePath.StartsWith("Images/", StringComparison.OrdinalIgnoreCase) ||
                    Path.IsPathRooted(ImagePath) == false)
                {
                    fullImagePath = Path.Combine(Application.StartupPath, ImagePath);
                }

                if (File.Exists(fullImagePath))
                {
                    pictureBox1.Image = Image.FromFile(fullImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox1.Image = null;
                }

                MakePictureBoxCircular();
            }
            catch { }
        }

        public void LoadCustomerData()
        {
            try
            {
                var mainform = this.FindForm() as MainForm;
                if (mainform == null || mainform.LoggedInCustomer == null)
                {
                    return;
                }

                Customer customer = mainform.LoggedInCustomer;

                lbl_cusid.Text = $"{customer.CustomerId}";
                lbl_accnum.Text = $"{customer.AccountNumber}";
                lbl_name.Text = $"{customer.FullName}";
                lbl_gender.Text = $"{customer.Gender}";
                lbl_bdate.Text = customer.Birthdate.ToString("MMMM dd, yyyy");
                lbl_address.Text = $"{customer.Address}";
                lbl_cnum.Text = $"{customer.Contact}";
                lbl_civilstatus.Text = $"{customer.CivilStatus}";
                lbl_email.Text = $"{customer.Email}";
                LoadCustomerImage(customer.ImagePath);

                int age = DateTime.Now.Year - customer.Birthdate.Year;
                if (customer.Birthdate > DateTime.Now.AddYears(-age)) age--;
                if (age == 1) lblage.Text = $"{age} year old";
                else lblage.Text = $"{age} years old";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Profile_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void lbl_bdate_Click(object sender, EventArgs e)
        {
        }

        private void lblage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
