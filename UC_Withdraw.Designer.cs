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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbx_accnum
            // 
            this.txtbx_accnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_accnum.Location = new System.Drawing.Point(205, 151);
            this.txtbx_accnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_accnum.Name = "txtbx_accnum";
            this.txtbx_accnum.Size = new System.Drawing.Size(443, 26);
            this.txtbx_accnum.TabIndex = 38;
            this.txtbx_accnum.TextChanged += new System.EventHandler(this.txtbx_accnum_TextChanged);
            this.txtbx_accnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_accnum_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Customer Account Number:";
            // 
            // txtbx_amount
            // 
            this.txtbx_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_amount.Location = new System.Drawing.Point(205, 241);
            this.txtbx_amount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbx_amount.Name = "txtbx_amount";
            this.txtbx_amount.Size = new System.Drawing.Size(443, 26);
            this.txtbx_amount.TabIndex = 36;
            this.txtbx_amount.TextChanged += new System.EventHandler(this.txtbx_amount_TextChanged);
            this.txtbx_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_amount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Enter Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Current Balance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 378);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "New Balance:";
            // 
            // lbl_currbal
            // 
            this.lbl_currbal.AutoSize = true;
            this.lbl_currbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currbal.Location = new System.Drawing.Point(360, 340);
            this.lbl_currbal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_currbal.Name = "lbl_currbal";
            this.lbl_currbal.Size = new System.Drawing.Size(45, 17);
            this.lbl_currbal.TabIndex = 42;
            this.lbl_currbal.Text = "₱0.00";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(363, 379);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(45, 17);
            this.lblAmount.TabIndex = 43;
            this.lblAmount.Text = "₱0.00";
            // 
            // lbl_newbal
            // 
            this.lbl_newbal.AutoSize = true;
            this.lbl_newbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newbal.Location = new System.Drawing.Point(363, 418);
            this.lbl_newbal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_newbal.Name = "lbl_newbal";
            this.lbl_newbal.Size = new System.Drawing.Size(45, 17);
            this.lbl_newbal.TabIndex = 44;
            this.lbl_newbal.Text = "₱0.00";
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_withdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_withdraw.FlatAppearance.BorderSize = 0;
            this.btn_withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_withdraw.ForeColor = System.Drawing.Color.White;
            this.btn_withdraw.Location = new System.Drawing.Point(377, 481);
            this.btn_withdraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(129, 39);
            this.btn_withdraw.TabIndex = 46;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = false;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 834);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1632, 30);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1619, 79);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(376, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 507);
            this.panel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Himalaya", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 54);
            this.label10.TabIndex = 27;
            this.label10.Text = "Withdraw";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(528, 482);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Account Name:";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(360, 308);
            this.lblAccountName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(13, 17);
            this.lblAccountName.TabIndex = 50;
            this.lblAccountName.Text = "-";
            this.lblAccountName.Click += new System.EventHandler(this.lblAccountName_Click);
            // 
            // UC_Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_withdraw);
            this.Controls.Add(this.lbl_newbal);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lbl_currbal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_accnum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_amount);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_Withdraw";
            this.Size = new System.Drawing.Size(1600, 862);
            this.Load += new System.EventHandler(this.UC_Withdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccountName;
    }
}
