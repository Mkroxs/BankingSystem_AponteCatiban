namespace BankingSystem_AponteCatiban
{
    partial class UC_CheckBalance_Cus
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
            this.lbl_rembal = new System.Windows.Forms.Label();
            this.lbl_accname = new System.Windows.Forms.Label();
            this.lbl_accnum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_rembal
            // 
            this.lbl_rembal.AutoSize = true;
            this.lbl_rembal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rembal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_rembal.Location = new System.Drawing.Point(290, 20);
            this.lbl_rembal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rembal.Name = "lbl_rembal";
            this.lbl_rembal.Size = new System.Drawing.Size(22, 22);
            this.lbl_rembal.TabIndex = 31;
            this.lbl_rembal.Text = "--";
            // 
            // lbl_accname
            // 
            this.lbl_accname.AutoSize = true;
            this.lbl_accname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_accname.Location = new System.Drawing.Point(238, 22);
            this.lbl_accname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accname.Name = "lbl_accname";
            this.lbl_accname.Size = new System.Drawing.Size(22, 22);
            this.lbl_accname.TabIndex = 30;
            this.lbl_accname.Text = "--";
            // 
            // lbl_accnum
            // 
            this.lbl_accnum.AutoSize = true;
            this.lbl_accnum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_accnum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_accnum.Location = new System.Drawing.Point(258, 22);
            this.lbl_accnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_accnum.Name = "lbl_accnum";
            this.lbl_accnum.Size = new System.Drawing.Size(22, 22);
            this.lbl_accnum.TabIndex = 29;
            this.lbl_accnum.Text = "--";
            this.lbl_accnum.Click += new System.EventHandler(this.lbl_accnum_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Remaining Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Account Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Account Number:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_rembal);
            this.panel1.Location = new System.Drawing.Point(14, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 68);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_accname);
            this.panel2.Location = new System.Drawing.Point(14, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 68);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lbl_accnum);
            this.panel3.Location = new System.Drawing.Point(14, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(670, 68);
            this.panel3.TabIndex = 33;
            // 
            // UC_CheckBalance_Cus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_CheckBalance_Cus";
            this.Size = new System.Drawing.Size(1600, 862);
            this.Load += new System.EventHandler(this.UC_CheckBalance_Cus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_rembal;
        private System.Windows.Forms.Label lbl_accname;
        private System.Windows.Forms.Label lbl_accnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
