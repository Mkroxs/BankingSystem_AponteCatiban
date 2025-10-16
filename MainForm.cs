using BankingSystem_AponteCatiban.Models;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BankingSystem_AponteCatiban
{
    public partial class MainForm : Form
    {
       
        public UC_Login login = new UC_Login();
        public UC_Deposit_Admin deposit_Admin = new UC_Deposit_Admin();
        public UC_Deposit_Cus deposit_customer = new UC_Deposit_Cus();
        public UC_Registration registration = new UC_Registration();
        public UC_CheckBalance_Admin checkBalance_Admin = new UC_CheckBalance_Admin();
        public UC_CheckBalance_Cus checkBalance_Cus = new UC_CheckBalance_Cus();
        public UC_CustomerProfile customerProfile = new UC_CustomerProfile();
        public UC_Profile profile = new UC_Profile();
        public UC_TransactionHistory transactionHistory = new UC_TransactionHistory();
        public UC_Withdraw withdraw = new UC_Withdraw();

        public Customer LoggedInCustomer { get; set; }

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private UserControl currentUC;

        public MainForm()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.Size = new Size(1000, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1000, 700);

            
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            panelCustomer.Controls.Add(leftBorderBtn);

            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            
            PreloadUserControls();

            login.Dock = DockStyle.Fill;
            registration.Dock = DockStyle.Fill;

            
            panelDesktop.Controls.Add(login);
            panelDesktop.Controls.Add(registration);
        }

        private void PreloadUserControls()
        {
            var ucs = new UserControl[]
            {
                deposit_Admin, deposit_customer, registration,
                checkBalance_Admin, checkBalance_Cus,
                customerProfile, profile, transactionHistory,
                withdraw
            };

            foreach (var uc in ucs)
            {
                uc.Dock = DockStyle.Fill;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HidePanels();
            panelDesktop.Show();
            login.BringToFront();
            login.Show();
        }

        
        public void HidePanels()
        {
            panelCustomer.Hide();
            panelMenu.Hide();
            panelTitleBar.Hide();
           
        }

        public void ShowAdminPanel()
        {
            panelCustomer.Hide();
            

            panelMenu.Show();
            panelTitleBar.Show();
            panelDesktop.Show();
        }

        public void ShowCustomerPanel()
        {
            panelMenu.Hide();
            panelCustomer.Show();
            panelTitleBar.Show();
            panelDesktop.Show();
        }

       
        private struct RGBColors
        {
            public static Color color1 = Color.LightBlue;
            public static Color color2 = Color.LightBlue;
            public static Color color3 = Color.LightBlue;
            public static Color color4 = Color.LightBlue;
            public static Color color5 = Color.LightBlue;
            public static Color color6 = Color.LightBlue;
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn == null) return;

            DisableButton();
            currentBtn = (IconButton)senderBtn;
            currentBtn.BackColor = Color.FromArgb(0, 40, 65);
            currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;

            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = panelMenu.BackColor;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        
        public void OpenChildControl(UserControl childControl)
        {
            if (childControl == null) return;

            
            if (currentUC != null)
            {
                currentUC.Hide();
            }

            currentUC = childControl;

            if (!panelDesktop.Controls.Contains(childControl))
            {
                panelDesktop.Controls.Add(childControl);
                childControl.Dock = DockStyle.Fill;
            }

            childControl.BringToFront();
            childControl.Show();
        }

        public void ClearCurrentUC()
        {
            if (currentUC != null)
            {
                panelDesktop.Controls.Remove(currentUC);
                currentUC.Hide();
                currentUC = null;
            }
        }

        
        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

           
            OpenChildControl(registration);

            lblTitleChildForm.Text = "Registration";
            registration.panelTitle.Visible = false;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildControl(deposit_Admin);
            lblTitleChildForm.Text = "Deposit";
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildControl(withdraw);
            lblTitleChildForm.Text = "Withdraw";
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildControl(checkBalance_Admin);
            lblTitleChildForm.Text = "Check Balance";
        }

        private void btnCustomerProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildControl(customerProfile);
            lblTitleChildForm.Text = "Customer Profile";
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            currentUC?.Hide();

            login.Show();
            login.BringToFront();
            registration.ClearFields();
            HidePanels();
            registration.panelTitle.Visible = true;
            registration.btn_cancel.Visible = true;
        }

       
        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildControl(deposit_customer);
            lblTitleChildForm.Text = "Deposit";
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildControl(profile);
            lblTitleChildForm.Text = "Profile";
        }

        private void btnCheckBalance2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildControl(checkBalance_Cus);
            lblTitleChildForm.Text = "Balance";
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildControl(transactionHistory);
            lblTitleChildForm.Text = "Transaction History";
        }

        private void btnLogout2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            currentUC?.Hide();
            transactionHistory.ResetLabels();
            login.Show();
            login.BringToFront();

            HidePanels();
        }

        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
