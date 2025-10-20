namespace BankingSystem_AponteCatiban
{
    partial class UC_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxuser = new System.Windows.Forms.TextBox();
            this.txtbxpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.logoAC = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hidepass = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoAC)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxuser
            // 
            this.txtbxuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxuser.BackColor = System.Drawing.Color.LightGray;
            this.txtbxuser.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxuser.Location = new System.Drawing.Point(22, 22);
            this.txtbxuser.Name = "txtbxuser";
            this.txtbxuser.Size = new System.Drawing.Size(223, 30);
            this.txtbxuser.TabIndex = 0;
            this.txtbxuser.TextChanged += new System.EventHandler(this.txtbxuser_TextChanged);
            // 
            // txtbxpass
            // 
            this.txtbxpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxpass.BackColor = System.Drawing.Color.LightGray;
            this.txtbxpass.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxpass.Location = new System.Drawing.Point(22, 79);
            this.txtbxpass.Name = "txtbxpass";
            this.txtbxpass.PasswordChar = '*';
            this.txtbxpass.Size = new System.Drawing.Size(223, 30);
            this.txtbxpass.TabIndex = 1;
            this.txtbxpass.TextChanged += new System.EventHandler(this.txtbxpass_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(128, 117);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(93, 32);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Log In";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.btnclose.Location = new System.Drawing.Point(22, 117);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(93, 32);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // lbl_Register
            // 
            this.lbl_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Register.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Register.Location = new System.Drawing.Point(185, 153);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(54, 16);
            this.lbl_Register.TabIndex = 6;
            this.lbl_Register.Text = "Sign up";
            this.lbl_Register.Click += new System.EventHandler(this.lbl_Register_Click);
            this.lbl_Register.MouseEnter += new System.EventHandler(this.lbl_Register_MouseEnter);
            this.lbl_Register.MouseLeave += new System.EventHandler(this.lbl_Register_MouseLeave);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogo.Location = new System.Drawing.Point(297, 155);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(278, 106);
            this.lblLogo.TabIndex = 8;
            this.lblLogo.Text = "Bank\r\nCorporation";
            // 
            // logoAC
            // 
            this.logoAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoAC.BackColor = System.Drawing.Color.Transparent;
            this.logoAC.BackgroundImage = global::BankingSystem_AponteCatiban.Properties.Resources.a2082dac_b7fc_4652_9f9f_c6a4b81a1a7a_removalai_preview;
            this.logoAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoAC.Location = new System.Drawing.Point(145, 81);
            this.logoAC.Margin = new System.Windows.Forms.Padding(2);
            this.logoAC.Name = "logoAC";
            this.logoAC.Size = new System.Drawing.Size(192, 210);
            this.logoAC.TabIndex = 7;
            this.logoAC.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 650);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.hidepass);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.showpass);
            this.panel2.Controls.Add(this.lblLogo);
            this.panel2.Controls.Add(this.logoAC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 648);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // hidepass
            // 
            this.hidepass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hidepass.BackColor = System.Drawing.Color.LightGray;
            this.hidepass.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidepass.Location = new System.Drawing.Point(735, 635);
            this.hidepass.Name = "hidepass";
            this.hidepass.PasswordChar = '*';
            this.hidepass.Size = new System.Drawing.Size(223, 30);
            this.hidepass.TabIndex = 13;
            this.hidepass.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbl_Register);
            this.panel3.Controls.Add(this.txtbxpass);
            this.panel3.Controls.Add(this.txtbxuser);
            this.panel3.Controls.Add(this.btnclose);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnlogin);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(240, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 180);
            this.panel3.TabIndex = 12;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.LightGray;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(209, 81);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 24);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(22, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Don\'t have an account?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // showpass
            // 
            this.showpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showpass.BackColor = System.Drawing.Color.LightGray;
            this.showpass.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass.Location = new System.Drawing.Point(735, 635);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(223, 30);
            this.showpass.TabIndex = 11;
            this.showpass.Visible = false;
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(750, 650);
            this.Load += new System.EventHandler(this.UC_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoAC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxuser;
        private System.Windows.Forms.TextBox txtbxpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox logoAC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox showpass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox hidepass;
    }
}