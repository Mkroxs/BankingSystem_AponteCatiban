namespace BankingSystem_AponteCatiban
{
    partial class UC_CheckBalance_Admin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_accnum = new System.Windows.Forms.Label();
            this.lbl_accname = new System.Windows.Forms.Label();
            this.lbl_rembal = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbxAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(21, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Account Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(21, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Account Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Remaining Balance:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_accnum
            // 
            this.lbl_accnum.AutoSize = true;
            this.lbl_accnum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accnum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_accnum.Location = new System.Drawing.Point(235, 124);
            this.lbl_accnum.Name = "lbl_accnum";
            this.lbl_accnum.Size = new System.Drawing.Size(22, 22);
            this.lbl_accnum.TabIndex = 22;
            this.lbl_accnum.Text = "--";
            this.lbl_accnum.Click += new System.EventHandler(this.lbl_accnum_Click);
            // 
            // lbl_accname
            // 
            this.lbl_accname.AutoSize = true;
            this.lbl_accname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_accname.Location = new System.Drawing.Point(235, 182);
            this.lbl_accname.Name = "lbl_accname";
            this.lbl_accname.Size = new System.Drawing.Size(22, 22);
            this.lbl_accname.TabIndex = 23;
            this.lbl_accname.Text = "--";
            this.lbl_accname.Click += new System.EventHandler(this.lbl_accname_Click);
            // 
            // lbl_rembal
            // 
            this.lbl_rembal.AutoSize = true;
            this.lbl_rembal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rembal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_rembal.Location = new System.Drawing.Point(235, 243);
            this.lbl_rembal.Name = "lbl_rembal";
            this.lbl_rembal.Size = new System.Drawing.Size(22, 22);
            this.lbl_rembal.TabIndex = 24;
            this.lbl_rembal.Text = "--";
            this.lbl_rembal.Click += new System.EventHandler(this.lbl_rembal_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, 680);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1204, 26);
            this.flowLayoutPanel1.TabIndex = 67;
            // 
            // tbxAccountNumber
            // 
            this.tbxAccountNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccountNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxAccountNumber.Location = new System.Drawing.Point(20, 42);
            this.tbxAccountNumber.Name = "tbxAccountNumber";
            this.tbxAccountNumber.Size = new System.Drawing.Size(267, 27);
            this.tbxAccountNumber.TabIndex = 68;
            this.tbxAccountNumber.TextChanged += new System.EventHandler(this.tbxAccountNumber_TextChanged);
            this.tbxAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAccountNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Customer Account Number:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxAccountNumber);
            this.panel1.Controls.Add(this.lbl_rembal);
            this.panel1.Controls.Add(this.lbl_accname);
            this.panel1.Controls.Add(this.lbl_accnum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 569);
            this.panel1.TabIndex = 70;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // UC_CheckBalance_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "UC_CheckBalance_Admin";
            this.Size = new System.Drawing.Size(900, 569);
            this.Load += new System.EventHandler(this.UC_CheckBalance_Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_accnum;
        private System.Windows.Forms.Label lbl_accname;
        private System.Windows.Forms.Label lbl_rembal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbxAccountNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}
