namespace BankingSystem_AponteCatiban
{
    partial class UC_Dashboard_Cus
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblprof = new System.Windows.Forms.Label();
            this.lbltransac_history = new System.Windows.Forms.Label();
            this.lblcheck_bal = new System.Windows.Forms.Label();
            this.lbldeposit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Log out";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblprof
            // 
            this.lblprof.AutoSize = true;
            this.lblprof.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprof.ForeColor = System.Drawing.Color.White;
            this.lblprof.Location = new System.Drawing.Point(73, 179);
            this.lblprof.Name = "lblprof";
            this.lblprof.Size = new System.Drawing.Size(77, 34);
            this.lblprof.TabIndex = 10;
            this.lblprof.Text = "Profile";
            // 
            // lbltransac_history
            // 
            this.lbltransac_history.AutoSize = true;
            this.lbltransac_history.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransac_history.ForeColor = System.Drawing.Color.White;
            this.lbltransac_history.Location = new System.Drawing.Point(73, 121);
            this.lbltransac_history.Name = "lbltransac_history";
            this.lbltransac_history.Size = new System.Drawing.Size(189, 34);
            this.lbltransac_history.TabIndex = 9;
            this.lbltransac_history.Text = "Transaction history";
            // 
            // lblcheck_bal
            // 
            this.lblcheck_bal.AutoSize = true;
            this.lblcheck_bal.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheck_bal.ForeColor = System.Drawing.Color.White;
            this.lblcheck_bal.Location = new System.Drawing.Point(73, 67);
            this.lblcheck_bal.Name = "lblcheck_bal";
            this.lblcheck_bal.Size = new System.Drawing.Size(150, 34);
            this.lblcheck_bal.TabIndex = 8;
            this.lblcheck_bal.Text = "Check Balance";
            // 
            // lbldeposit
            // 
            this.lbldeposit.AutoSize = true;
            this.lbldeposit.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeposit.ForeColor = System.Drawing.Color.White;
            this.lbldeposit.Location = new System.Drawing.Point(73, 16);
            this.lbldeposit.Name = "lbldeposit";
            this.lbldeposit.Size = new System.Drawing.Size(84, 34);
            this.lbldeposit.TabIndex = 7;
            this.lbldeposit.Text = "Deposit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 63);
            this.panel1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Himalaya", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 54);
            this.label2.TabIndex = 27;
            this.label2.Text = "KNAB CENTRAL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lbltransac_history);
            this.panel2.Controls.Add(this.lbldeposit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblcheck_bal);
            this.panel2.Controls.Add(this.lblprof);
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 413);
            this.panel2.TabIndex = 30;
            // 
            // UC_Dashboard_Cus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Dashboard_Cus";
            this.Size = new System.Drawing.Size(747, 476);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblprof;
        private System.Windows.Forms.Label lbltransac_history;
        private System.Windows.Forms.Label lblcheck_bal;
        private System.Windows.Forms.Label lbldeposit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}
