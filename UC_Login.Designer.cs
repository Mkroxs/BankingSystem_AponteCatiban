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
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoAC)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxuser
            // 
            this.txtbxuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxuser.BackColor = System.Drawing.Color.LightGray;
            this.txtbxuser.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxuser.Location = new System.Drawing.Point(348, 385);
            this.txtbxuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxuser.Name = "txtbxuser";
            this.txtbxuser.Size = new System.Drawing.Size(296, 30);
            this.txtbxuser.TabIndex = 0;
            this.txtbxuser.TextChanged += new System.EventHandler(this.txtbxuser_TextChanged);
            // 
            // txtbxpass
            // 
            this.txtbxpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxpass.BackColor = System.Drawing.Color.LightGray;
            this.txtbxpass.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxpass.Location = new System.Drawing.Point(348, 456);
            this.txtbxpass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxpass.Name = "txtbxpass";
            this.txtbxpass.PasswordChar = '*';
            this.txtbxpass.Size = new System.Drawing.Size(296, 30);
            this.txtbxpass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(344, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.label2.Location = new System.Drawing.Point(343, 429);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.btnlogin.Location = new System.Drawing.Point(489, 502);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(124, 39);
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
            this.btnclose.Location = new System.Drawing.Point(348, 502);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(124, 39);
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
            this.lbl_Register.Location = new System.Drawing.Point(608, 546);
            this.lbl_Register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lblLogo.Location = new System.Drawing.Point(395, 189);
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
            this.logoAC.Location = new System.Drawing.Point(192, 99);
            this.logoAC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoAC.Name = "logoAC";
            this.logoAC.Size = new System.Drawing.Size(256, 258);
            this.logoAC.TabIndex = 7;
            this.logoAC.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 800);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_Register);
            this.panel2.Controls.Add(this.txtbxpass);
            this.panel2.Controls.Add(this.lblLogo);
            this.panel2.Controls.Add(this.txtbxuser);
            this.panel2.Controls.Add(this.logoAC);
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 796);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(348, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Don\'t have an account?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(1000, 800);
            this.Load += new System.EventHandler(this.UC_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoAC)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}