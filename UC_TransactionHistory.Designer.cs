namespace BankingSystem_AponteCatiban
{
    partial class UC_TransactionHistory
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_dateoftrans = new System.Windows.Forms.Label();
            this.lbl_transtype = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_prevbal = new System.Windows.Forms.Label();
            this.lbl_newbal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_cuslist = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuslist)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Transaction Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date of Transaction:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "New Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "Previous Balance:";
            // 
            // lbl_dateoftrans
            // 
            this.lbl_dateoftrans.AutoSize = true;
            this.lbl_dateoftrans.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateoftrans.Location = new System.Drawing.Point(284, 18);
            this.lbl_dateoftrans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dateoftrans.Name = "lbl_dateoftrans";
            this.lbl_dateoftrans.Size = new System.Drawing.Size(16, 22);
            this.lbl_dateoftrans.TabIndex = 34;
            this.lbl_dateoftrans.Text = "-";
            // 
            // lbl_transtype
            // 
            this.lbl_transtype.AutoSize = true;
            this.lbl_transtype.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transtype.Location = new System.Drawing.Point(284, 18);
            this.lbl_transtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_transtype.Name = "lbl_transtype";
            this.lbl_transtype.Size = new System.Drawing.Size(16, 22);
            this.lbl_transtype.TabIndex = 35;
            this.lbl_transtype.Text = "-";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(284, 18);
            this.lbl_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(16, 22);
            this.lbl_amount.TabIndex = 36;
            this.lbl_amount.Text = "-";
            // 
            // lbl_prevbal
            // 
            this.lbl_prevbal.AutoSize = true;
            this.lbl_prevbal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prevbal.Location = new System.Drawing.Point(284, 18);
            this.lbl_prevbal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_prevbal.Name = "lbl_prevbal";
            this.lbl_prevbal.Size = new System.Drawing.Size(16, 22);
            this.lbl_prevbal.TabIndex = 37;
            this.lbl_prevbal.Text = "-";
            // 
            // lbl_newbal
            // 
            this.lbl_newbal.AutoSize = true;
            this.lbl_newbal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newbal.Location = new System.Drawing.Point(284, 18);
            this.lbl_newbal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_newbal.Name = "lbl_newbal";
            this.lbl_newbal.Size = new System.Drawing.Size(16, 22);
            this.lbl_newbal.TabIndex = 38;
            this.lbl_newbal.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "Transaction Record:";
            // 
            // dgv_cuslist
            // 
            this.dgv_cuslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuslist.Location = new System.Drawing.Point(27, 354);
            this.dgv_cuslist.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_cuslist.Name = "dgv_cuslist";
            this.dgv_cuslist.Size = new System.Drawing.Size(827, 276);
            this.dgv_cuslist.TabIndex = 40;
            this.dgv_cuslist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cuslist_CellClick);
            this.dgv_cuslist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cuslist_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 837);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1603, 30);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_dateoftrans);
            this.panel1.Location = new System.Drawing.Point(3, 251);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 56);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_transtype);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 56);
            this.panel2.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lbl_amount);
            this.panel3.Location = new System.Drawing.Point(3, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(577, 56);
            this.panel3.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lbl_prevbal);
            this.panel4.Location = new System.Drawing.Point(3, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(577, 56);
            this.panel4.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lbl_newbal);
            this.panel5.Location = new System.Drawing.Point(3, 189);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(577, 56);
            this.panel5.TabIndex = 43;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(26, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(616, 318);
            this.flowLayoutPanel2.TabIndex = 44;
            // 
            // UC_TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_cuslist);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_TransactionHistory";
            this.Size = new System.Drawing.Size(1600, 862);
            this.Load += new System.EventHandler(this.UC_TransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuslist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_dateoftrans;
        private System.Windows.Forms.Label lbl_transtype;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_prevbal;
        private System.Windows.Forms.Label lbl_newbal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_cuslist;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
