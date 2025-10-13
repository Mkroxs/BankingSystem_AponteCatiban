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
        // --- All user controls ---
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
        public UC_InitialDeposit initialDeposit = new UC_InitialDeposit();

        public Customer LoggedInCustomer { get; set; }

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private UserControl currentUC;

        public MainForm()
        {
            InitializeComponent();

            // --- Default size when launching ---
            this.Size = new Size(1100, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1000, 700);

            // --- Prepare navigation indicator ---
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            panelCustomer.Controls.Add(leftBorderBtn);

            // --- Style adjustments ---
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // --- Preload all UCs ---
            PreloadUserControls();

            login.Dock = DockStyle.Fill;
            registration.Dock = DockStyle.Fill;

            // ✅ Add login and registration to the same panelDesktop
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
                withdraw, initialDeposit
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

        // --- Hide panels when not logged in ---
        public void HidePanels()
        {
            panelCustomer.Hide();
            panelMenu.Hide();
            panelTitleBar.Hide();
            panelDesktop.Hide();
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

        // --- Colors ---
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
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
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

        // --- UC management ---
        public void OpenChildControl(UserControl childControl)
        {
            if (currentUC != null)
            {
                panelDesktop.Controls.Remove(currentUC);
            }

            currentUC = childControl;
            panelDesktop.Controls.Add(childControl);
            childControl.Dock = DockStyle.Fill;
            childControl.BringToFront();
        }

        public void ClearCurrentUC()
        {
            if (currentUC != null)
            {
                panelDesktop.Controls.Remove(currentUC);
                currentUC.Dispose();
                currentUC = null;
            }
        }

        // --- Buttons ---
        private void btnRegisterCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            if (!panelDesktop.Controls.Contains(registration))
            {
                registration.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(registration);
            }

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
            ClearCurrentUC();
            panelDesktop.Controls.Clear();

            panelDesktop.Controls.Add(login);
            panelDesktop.Controls.Add(registration);

            login.BringToFront();
            login.Show();
            HidePanels();
            registration.panelTitle.Visible = true;
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
            ClearCurrentUC();
            panelDesktop.Controls.Clear();

            panelDesktop.Controls.Add(login);
            panelDesktop.Controls.Add(registration);

            login.BringToFront();
            login.Show();
            HidePanels();
        }

        // --- Allow dragging form window ---
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
