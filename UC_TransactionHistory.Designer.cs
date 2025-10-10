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
            this.btn_close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_cuslist = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuslist)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Transaction Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date of Transaction:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "New Balance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Previous Balance:";
            // 
            // lbl_dateoftrans
            // 
            this.lbl_dateoftrans.AutoSize = true;
            this.lbl_dateoftrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateoftrans.Location = new System.Drawing.Point(208, 110);
            this.lbl_dateoftrans.Name = "lbl_dateoftrans";
            this.lbl_dateoftrans.Size = new System.Drawing.Size(92, 24);
            this.lbl_dateoftrans.TabIndex = 34;
            this.lbl_dateoftrans.Text = "Dt of trans";
            // 
            // lbl_transtype
            // 
            this.lbl_transtype.AutoSize = true;
            this.lbl_transtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_transtype.Location = new System.Drawing.Point(208, 158);
            this.lbl_transtype.Name = "lbl_transtype";
            this.lbl_transtype.Size = new System.Drawing.Size(106, 24);
            this.lbl_transtype.TabIndex = 35;
            this.lbl_transtype.Text = "Trans Type";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amount.Location = new System.Drawing.Point(208, 203);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(76, 24);
            this.lbl_amount.TabIndex = 36;
            this.lbl_amount.Text = "Amount";
            // 
            // lbl_prevbal
            // 
            this.lbl_prevbal.AutoSize = true;
            this.lbl_prevbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prevbal.Location = new System.Drawing.Point(208, 248);
            this.lbl_prevbal.Name = "lbl_prevbal";
            this.lbl_prevbal.Size = new System.Drawing.Size(79, 24);
            this.lbl_prevbal.TabIndex = 37;
            this.lbl_prevbal.Text = "Prev Bal";
            // 
            // lbl_newbal
            // 
            this.lbl_newbal.AutoSize = true;
            this.lbl_newbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newbal.Location = new System.Drawing.Point(208, 294);
            this.lbl_newbal.Name = "lbl_newbal";
            this.lbl_newbal.Size = new System.Drawing.Size(80, 24);
            this.lbl_newbal.TabIndex = 38;
            this.lbl_newbal.Text = "New Bal";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(637, 421);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 36);
            this.btn_close.TabIndex = 39;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Transaction Record:";
            // 
            // dgv_cuslist
            // 
            this.dgv_cuslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cuslist.Location = new System.Drawing.Point(351, 110);
            this.dgv_cuslist.Name = "dgv_cuslist";
            this.dgv_cuslist.Size = new System.Drawing.Size(378, 129);
            this.dgv_cuslist.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 64);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(282, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 412);
            this.panel2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Himalaya", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(310, 54);
            this.label10.TabIndex = 27;
            this.label10.Text = "Transaction History";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 466);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(749, 10);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // UC_TransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_cuslist);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lbl_newbal);
            this.Controls.Add(this.lbl_prevbal);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_transtype);
            this.Controls.Add(this.lbl_dateoftrans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UC_TransactionHistory";
            this.Size = new System.Drawing.Size(747, 476);
            this.Load += new System.EventHandler(this.UC_TransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cuslist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_cuslist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
