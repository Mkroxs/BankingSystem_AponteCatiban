namespace BankingSystem_AponteCatiban
{
    partial class UC_Withdraw
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
            this.txtbx_accnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_currbal = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lbl_newbal = new System.Windows.Forms.Label();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_accnum
            // 
            this.txtbx_accnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_accnum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbx_accnum.Location = new System.Drawing.Point(56, 60);
            this.txtbx_accnum.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_accnum.Name = "txtbx_accnum";
            this.txtbx_accnum.Size = new System.Drawing.Size(443, 29);
            this.txtbx_accnum.TabIndex = 38;
            this.txtbx_accnum.TextChanged += new System.EventHandler(this.txtbx_accnum_TextChanged);
            this.txtbx_accnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_accnum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(51, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Customer Account Number:";
            // 
            // txtbx_amount
            // 
            this.txtbx_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_amount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbx_amount.Location = new System.Drawing.Point(56, 150);
            this.txtbx_amount.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_amount.Name = "txtbx_amount";
            this.txtbx_amount.Size = new System.Drawing.Size(443, 29);
            this.txtbx_amount.TabIndex = 36;
            this.txtbx_amount.TextChanged += new System.EventHandler(this.txtbx_amount_TextChanged);
            this.txtbx_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_amount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(51, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Enter Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(61, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Current Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(61, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(61, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "New Balance:";
            // 
            // lbl_currbal
            // 
            this.lbl_currbal.AutoSize = true;
            this.lbl_currbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currbal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_currbal.Location = new System.Drawing.Point(278, 250);
            this.lbl_currbal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_currbal.Name = "lbl_currbal";
            this.lbl_currbal.Size = new System.Drawing.Size(51, 20);
            this.lbl_currbal.TabIndex = 42;
            this.lbl_currbal.Text = "₱0.00";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmount.Location = new System.Drawing.Point(279, 288);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 20);
            this.lblAmount.TabIndex = 43;
            this.lblAmount.Text = "₱0.00";
            // 
            // lbl_newbal
            // 
            this.lbl_newbal.AutoSize = true;
            this.lbl_newbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newbal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_newbal.Location = new System.Drawing.Point(280, 328);
            this.lbl_newbal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_newbal.Name = "lbl_newbal";
            this.lbl_newbal.Size = new System.Drawing.Size(51, 20);
            this.lbl_newbal.TabIndex = 44;
            this.lbl_newbal.Text = "₱0.00";
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_withdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_withdraw.FlatAppearance.BorderSize = 0;
            this.btn_withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_withdraw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_withdraw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_withdraw.Location = new System.Drawing.Point(228, 390);
            this.btn_withdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(129, 39);
            this.btn_withdraw.TabIndex = 46;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = false;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_clear.Location = new System.Drawing.Point(379, 390);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(129, 39);
            this.btn_clear.TabIndex = 48;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(61, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Account Name:";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountName.Location = new System.Drawing.Point(283, 216);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(14, 20);
            this.lblAccountName.TabIndex = 50;
            this.lblAccountName.Text = "-";
            this.lblAccountName.Click += new System.EventHandler(this.lblAccountName_Click);
            // 
            // UC_Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_newbal);
            this.Controls.Add(this.txtbx_amount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtbx_accnum);
            this.Controls.Add(this.lbl_currbal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Withdraw";
            this.Size = new System.Drawing.Size(1600, 862);
            this.Load += new System.EventHandler(this.UC_Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbx_accnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_currbal;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lbl_newbal;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountName;
    }
}
