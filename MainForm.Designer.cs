namespace BankingSystem_AponteCatiban
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.logoAC = new System.Windows.Forms.PictureBox();
            this.btnRegisterCustomer = new FontAwesome.Sharp.IconButton();
            this.btnDeposit = new FontAwesome.Sharp.IconButton();
            this.btnWithdraw = new FontAwesome.Sharp.IconButton();
            this.btnCheckBalance = new FontAwesome.Sharp.IconButton();
            this.btnCustomerProfile = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.btnLogout2 = new FontAwesome.Sharp.IconButton();
            this.btnTransactionHistory = new FontAwesome.Sharp.IconButton();
            this.btnCheckBalance2 = new FontAwesome.Sharp.IconButton();
            this.btnDeposit2 = new FontAwesome.Sharp.IconButton();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoAC)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(443, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(457, 99);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitleChildForm.Location = new System.Drawing.Point(16, 23);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(0, 64);
            this.lblTitleChildForm.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Silver;
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(443, 99);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(457, 551);
            this.panelDesktop.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 551);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 551);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Controls.Add(this.logoAC);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.panelLogo.Size = new System.Drawing.Size(217, 99);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogo.Location = new System.Drawing.Point(74, 34);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(109, 42);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Bank\r\nCorporation";
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // logoAC
            // 
            this.logoAC.BackgroundImage = global::BankingSystem_AponteCatiban.Properties.Resources.a2082dac_b7fc_4652_9f9f_c6a4b81a1a7a_removalai_preview;
            this.logoAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoAC.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoAC.Location = new System.Drawing.Point(8, 0);
            this.logoAC.Margin = new System.Windows.Forms.Padding(2);
            this.logoAC.Name = "logoAC";
            this.logoAC.Size = new System.Drawing.Size(78, 99);
            this.logoAC.TabIndex = 0;
            this.logoAC.TabStop = false;
            // 
            // btnRegisterCustomer
            // 
            this.btnRegisterCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterCustomer.FlatAppearance.BorderSize = 0;
            this.btnRegisterCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterCustomer.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRegisterCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegisterCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnRegisterCustomer.IconColor = System.Drawing.Color.White;
            this.btnRegisterCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegisterCustomer.IconSize = 32;
            this.btnRegisterCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterCustomer.Location = new System.Drawing.Point(0, 307);
            this.btnRegisterCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnRegisterCustomer.Size = new System.Drawing.Size(217, 49);
            this.btnRegisterCustomer.TabIndex = 1;
            this.btnRegisterCustomer.Text = "Register Customer";
            this.btnRegisterCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterCustomer.Click += new System.EventHandler(this.btnRegisterCustomer_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeposit.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnDeposit.IconColor = System.Drawing.Color.White;
            this.btnDeposit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeposit.IconSize = 32;
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(0, 209);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnDeposit.Size = new System.Drawing.Size(217, 49);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWithdraw.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnWithdraw.IconColor = System.Drawing.Color.White;
            this.btnWithdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWithdraw.IconSize = 32;
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(0, 160);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(217, 49);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckBalance.FlatAppearance.BorderSize = 0;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCheckBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckBalance.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnCheckBalance.IconColor = System.Drawing.Color.White;
            this.btnCheckBalance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckBalance.IconSize = 32;
            this.btnCheckBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckBalance.Location = new System.Drawing.Point(0, 258);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnCheckBalance.Size = new System.Drawing.Size(217, 49);
            this.btnCheckBalance.TabIndex = 4;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnCustomerProfile
            // 
            this.btnCustomerProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerProfile.FlatAppearance.BorderSize = 0;
            this.btnCustomerProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerProfile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomerProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnCustomerProfile.IconColor = System.Drawing.Color.White;
            this.btnCustomerProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomerProfile.IconSize = 32;
            this.btnCustomerProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerProfile.Location = new System.Drawing.Point(0, 99);
            this.btnCustomerProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerProfile.Name = "btnCustomerProfile";
            this.btnCustomerProfile.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnCustomerProfile.Size = new System.Drawing.Size(217, 61);
            this.btnCustomerProfile.TabIndex = 5;
            this.btnCustomerProfile.Text = "Customer Profile";
            this.btnCustomerProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerProfile.UseVisualStyleBackColor = true;
            this.btnCustomerProfile.Click += new System.EventHandler(this.btnCustomerProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 580);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnLogout.Size = new System.Drawing.Size(217, 70);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.btnRegisterCustomer);
            this.panelMenu.Controls.Add(this.btnCheckBalance);
            this.panelMenu.Controls.Add(this.btnDeposit);
            this.panelMenu.Controls.Add(this.btnWithdraw);
            this.panelMenu.Controls.Add(this.btnCustomerProfile);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(226, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(217, 650);
            this.panelMenu.TabIndex = 1;
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelCustomer.Controls.Add(this.btnLogout2);
            this.panelCustomer.Controls.Add(this.btnTransactionHistory);
            this.panelCustomer.Controls.Add(this.btnCheckBalance2);
            this.panelCustomer.Controls.Add(this.btnDeposit2);
            this.panelCustomer.Controls.Add(this.btnProfile);
            this.panelCustomer.Controls.Add(this.panel2);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(226, 650);
            this.panelCustomer.TabIndex = 4;
            // 
            // btnLogout2
            // 
            this.btnLogout2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout2.FlatAppearance.BorderSize = 0;
            this.btnLogout2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout2.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout2.IconColor = System.Drawing.Color.White;
            this.btnLogout2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout2.IconSize = 32;
            this.btnLogout2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout2.Location = new System.Drawing.Point(0, 580);
            this.btnLogout2.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout2.Name = "btnLogout2";
            this.btnLogout2.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnLogout2.Size = new System.Drawing.Size(226, 70);
            this.btnLogout2.TabIndex = 6;
            this.btnLogout2.Text = "Log out";
            this.btnLogout2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout2.UseVisualStyleBackColor = true;
            this.btnLogout2.Click += new System.EventHandler(this.btnLogout2_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionHistory.FlatAppearance.BorderSize = 0;
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnTransactionHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTransactionHistory.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.btnTransactionHistory.IconColor = System.Drawing.Color.White;
            this.btnTransactionHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransactionHistory.IconSize = 32;
            this.btnTransactionHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionHistory.Location = new System.Drawing.Point(0, 246);
            this.btnTransactionHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnTransactionHistory.Size = new System.Drawing.Size(226, 49);
            this.btnTransactionHistory.TabIndex = 5;
            this.btnTransactionHistory.Text = "Transaction History";
            this.btnTransactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransactionHistory.UseVisualStyleBackColor = true;
            this.btnTransactionHistory.Click += new System.EventHandler(this.btnTransactionHistory_Click);
            // 
            // btnCheckBalance2
            // 
            this.btnCheckBalance2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckBalance2.FlatAppearance.BorderSize = 0;
            this.btnCheckBalance2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCheckBalance2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckBalance2.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnCheckBalance2.IconColor = System.Drawing.Color.White;
            this.btnCheckBalance2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckBalance2.IconSize = 32;
            this.btnCheckBalance2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckBalance2.Location = new System.Drawing.Point(0, 197);
            this.btnCheckBalance2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckBalance2.Name = "btnCheckBalance2";
            this.btnCheckBalance2.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnCheckBalance2.Size = new System.Drawing.Size(226, 49);
            this.btnCheckBalance2.TabIndex = 4;
            this.btnCheckBalance2.Text = "Check Balance";
            this.btnCheckBalance2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckBalance2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckBalance2.UseVisualStyleBackColor = true;
            this.btnCheckBalance2.Click += new System.EventHandler(this.btnCheckBalance2_Click);
            // 
            // btnDeposit2
            // 
            this.btnDeposit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeposit2.FlatAppearance.BorderSize = 0;
            this.btnDeposit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnDeposit2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeposit2.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnDeposit2.IconColor = System.Drawing.Color.White;
            this.btnDeposit2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeposit2.IconSize = 32;
            this.btnDeposit2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit2.Location = new System.Drawing.Point(0, 148);
            this.btnDeposit2.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeposit2.Name = "btnDeposit2";
            this.btnDeposit2.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnDeposit2.Size = new System.Drawing.Size(226, 49);
            this.btnDeposit2.TabIndex = 2;
            this.btnDeposit2.Text = "Deposit";
            this.btnDeposit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposit2.UseVisualStyleBackColor = true;
            this.btnDeposit2.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnProfile.IconColor = System.Drawing.Color.White;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.IconSize = 32;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 99);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btnProfile.Size = new System.Drawing.Size(226, 49);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.panel2.Size = new System.Drawing.Size(226, 99);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank\r\nCorporation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BankingSystem_AponteCatiban.Properties.Resources.a2082dac_b7fc_4652_9f9f_c6a4b81a1a7a_removalai_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 99);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoAC)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelCustomer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox logoAC;
        private FontAwesome.Sharp.IconButton btnRegisterCustomer;
        private FontAwesome.Sharp.IconButton btnDeposit;
        private FontAwesome.Sharp.IconButton btnWithdraw;
        private FontAwesome.Sharp.IconButton btnCheckBalance;
        private FontAwesome.Sharp.IconButton btnCustomerProfile;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnLogout2;
        private FontAwesome.Sharp.IconButton btnTransactionHistory;
        private FontAwesome.Sharp.IconButton btnCheckBalance2;
        private FontAwesome.Sharp.IconButton btnDeposit2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnProfile;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblTitleChildForm;
        public System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panelTitleBar;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Panel panelCustomer;
    }
}

