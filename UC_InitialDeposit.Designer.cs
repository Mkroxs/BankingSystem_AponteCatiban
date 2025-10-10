namespace BankingSystem_AponteCatiban
{
    partial class UC_InitialDeposit
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.lbl_totalamount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.btn_200 = new System.Windows.Forms.Button();
            this.btn_500 = new System.Windows.Forms.Button();
            this.btn_1000 = new System.Windows.Forms.Button();
            this.txtbx_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear.Location = new System.Drawing.Point(418, 437);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 34);
            this.btn_clear.TabIndex = 56;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-16, 485);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(749, 10);
            this.flowLayoutPanel1.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-16, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 64);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(282, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 412);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Himalaya", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 54);
            this.label5.TabIndex = 27;
            this.label5.Text = "Deposit";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_confirm.FlatAppearance.BorderSize = 0;
            this.btn_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_confirm.Location = new System.Drawing.Point(504, 437);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 32);
            this.btn_confirm.TabIndex = 53;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // lbl_totalamount
            // 
            this.lbl_totalamount.AutoSize = true;
            this.lbl_totalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalamount.Location = new System.Drawing.Point(380, 383);
            this.lbl_totalamount.Name = "lbl_totalamount";
            this.lbl_totalamount.Size = new System.Drawing.Size(29, 20);
            this.lbl_totalamount.TabIndex = 52;
            this.lbl_totalamount.Text = "₱0";
            this.lbl_totalamount.Click += new System.EventHandler(this.lbl_totalamount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "Total Amount:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(332, 435);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 36);
            this.btn_cancel.TabIndex = 50;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(424, 320);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 36);
            this.btn_1.TabIndex = 49;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(299, 320);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 36);
            this.btn_5.TabIndex = 48;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            // 
            // btn_10
            // 
            this.btn_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_10.Location = new System.Drawing.Point(166, 320);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(75, 36);
            this.btn_10.TabIndex = 47;
            this.btn_10.Text = "10";
            this.btn_10.UseVisualStyleBackColor = true;
            // 
            // btn_20
            // 
            this.btn_20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_20.Location = new System.Drawing.Point(424, 259);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(75, 36);
            this.btn_20.TabIndex = 46;
            this.btn_20.Text = "20";
            this.btn_20.UseVisualStyleBackColor = true;
            // 
            // btn_50
            // 
            this.btn_50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_50.Location = new System.Drawing.Point(299, 259);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(75, 36);
            this.btn_50.TabIndex = 45;
            this.btn_50.Text = "50";
            this.btn_50.UseVisualStyleBackColor = true;
            // 
            // btn_100
            // 
            this.btn_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_100.Location = new System.Drawing.Point(166, 259);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(75, 36);
            this.btn_100.TabIndex = 44;
            this.btn_100.Text = "100";
            this.btn_100.UseVisualStyleBackColor = true;
            // 
            // btn_200
            // 
            this.btn_200.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_200.Location = new System.Drawing.Point(424, 197);
            this.btn_200.Name = "btn_200";
            this.btn_200.Size = new System.Drawing.Size(75, 36);
            this.btn_200.TabIndex = 43;
            this.btn_200.Text = "200";
            this.btn_200.UseVisualStyleBackColor = true;
            // 
            // btn_500
            // 
            this.btn_500.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_500.Location = new System.Drawing.Point(299, 197);
            this.btn_500.Name = "btn_500";
            this.btn_500.Size = new System.Drawing.Size(75, 36);
            this.btn_500.TabIndex = 42;
            this.btn_500.Text = "500";
            this.btn_500.UseVisualStyleBackColor = true;
            // 
            // btn_1000
            // 
            this.btn_1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1000.Location = new System.Drawing.Point(166, 197);
            this.btn_1000.Name = "btn_1000";
            this.btn_1000.Size = new System.Drawing.Size(75, 36);
            this.btn_1000.TabIndex = 41;
            this.btn_1000.Text = "1000";
            this.btn_1000.UseVisualStyleBackColor = true;
            // 
            // txtbx_amount
            // 
            this.txtbx_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_amount.Location = new System.Drawing.Point(166, 140);
            this.txtbx_amount.Name = "txtbx_amount";
            this.txtbx_amount.Size = new System.Drawing.Size(333, 26);
            this.txtbx_amount.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Enter Amount:";
            // 
            // UC_InitialDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_totalamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_20);
            this.Controls.Add(this.btn_50);
            this.Controls.Add(this.btn_100);
            this.Controls.Add(this.btn_200);
            this.Controls.Add(this.btn_500);
            this.Controls.Add(this.btn_1000);
            this.Controls.Add(this.txtbx_amount);
            this.Controls.Add(this.label2);
            this.Name = "UC_InitialDeposit";
            this.Size = new System.Drawing.Size(732, 494);
            this.Load += new System.EventHandler(this.UC_InitialDeposit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Button btn_200;
        private System.Windows.Forms.Button btn_500;
        private System.Windows.Forms.Button btn_1000;
        private System.Windows.Forms.TextBox txtbx_amount;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_totalamount;
    }
}
