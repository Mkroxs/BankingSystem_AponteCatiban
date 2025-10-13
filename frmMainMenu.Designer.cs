namespace BankingSystem_AponteCatiban
{
    partial class frmMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnCustomerProfile = new FontAwesome.Sharp.IconButton();
            this.btnCheckBalance = new FontAwesome.Sharp.IconButton();
            this.btnWithdraw = new FontAwesome.Sharp.IconButton();
            this.btnDeposit = new FontAwesome.Sharp.IconButton();
            this.btnRegisterCustomer = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnCustomerProfile);
            this.panelMenu.Controls.Add(this.btnCheckBalance);
            this.panelMenu.Controls.Add(this.btnWithdraw);
            this.panelMenu.Controls.Add(this.btnDeposit);
            this.panelMenu.Controls.Add(this.btnRegisterCustomer);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 644);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 584);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 60);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCustomerProfile
            // 
            this.btnCustomerProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerProfile.FlatAppearance.BorderSize = 0;
            this.btnCustomerProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCustomerProfile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnCustomerProfile.IconColor = System.Drawing.Color.White;
            this.btnCustomerProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomerProfile.IconSize = 32;
            this.btnCustomerProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerProfile.Location = new System.Drawing.Point(0, 362);
            this.btnCustomerProfile.Name = "btnCustomerProfile";
            this.btnCustomerProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCustomerProfile.Size = new System.Drawing.Size(220, 60);
            this.btnCustomerProfile.TabIndex = 5;
            this.btnCustomerProfile.Text = "Customer Profile";
            this.btnCustomerProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomerProfile.UseVisualStyleBackColor = true;
            this.btnCustomerProfile.Click += new System.EventHandler(this.btnCustomerProfile_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckBalance.FlatAppearance.BorderSize = 0;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBalance.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCheckBalance.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.btnCheckBalance.IconColor = System.Drawing.Color.White;
            this.btnCheckBalance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckBalance.IconSize = 32;
            this.btnCheckBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckBalance.Location = new System.Drawing.Point(0, 302);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCheckBalance.Size = new System.Drawing.Size(220, 60);
            this.btnCheckBalance.TabIndex = 4;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWithdraw.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnWithdraw.IconColor = System.Drawing.Color.White;
            this.btnWithdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWithdraw.IconSize = 32;
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.Location = new System.Drawing.Point(0, 242);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(220, 60);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWithdraw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeposit.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnDeposit.IconColor = System.Drawing.Color.White;
            this.btnDeposit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeposit.IconSize = 32;
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.Location = new System.Drawing.Point(0, 182);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDeposit.Size = new System.Drawing.Size(220, 60);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeposit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnRegisterCustomer
            // 
            this.btnRegisterCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegisterCustomer.FlatAppearance.BorderSize = 0;
            this.btnRegisterCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterCustomer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCustomer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegisterCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnRegisterCustomer.IconColor = System.Drawing.Color.White;
            this.btnRegisterCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegisterCustomer.IconSize = 32;
            this.btnRegisterCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterCustomer.Location = new System.Drawing.Point(0, 122);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRegisterCustomer.Size = new System.Drawing.Size(220, 60);
            this.btnRegisterCustomer.TabIndex = 1;
            this.btnRegisterCustomer.Text = "Register Customer";
            this.btnRegisterCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegisterCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterCustomer.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 122);
            this.panelLogo.TabIndex = 0;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 644);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmMainMenu";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnRegisterCustomer;
        private FontAwesome.Sharp.IconButton btnCustomerProfile;
        private FontAwesome.Sharp.IconButton btnCheckBalance;
        private FontAwesome.Sharp.IconButton btnWithdraw;
        private FontAwesome.Sharp.IconButton btnDeposit;
        private FontAwesome.Sharp.IconButton btnLogout;

        
    }
}