namespace BankingSystem_AponteCatiban
{
    partial class UC_Dashboard_Admin
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
            this.lblregister = new System.Windows.Forms.Label();
            this.lbldeposit = new System.Windows.Forms.Label();
            this.lblwithdraw = new System.Windows.Forms.Label();
            this.lblcheck_bal = new System.Windows.Forms.Label();
            this.lblcus_prof = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblregister
            // 
            this.lblregister.AutoSize = true;
            this.lblregister.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregister.Location = new System.Drawing.Point(75, 89);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(184, 34);
            this.lblregister.TabIndex = 0;
            this.lblregister.Text = "Register Customer";
            // 
            // lbldeposit
            // 
            this.lbldeposit.AutoSize = true;
            this.lbldeposit.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeposit.Location = new System.Drawing.Point(75, 139);
            this.lbldeposit.Name = "lbldeposit";
            this.lbldeposit.Size = new System.Drawing.Size(84, 34);
            this.lbldeposit.TabIndex = 1;
            this.lbldeposit.Text = "Deposit";
            // 
            // lblwithdraw
            // 
            this.lblwithdraw.AutoSize = true;
            this.lblwithdraw.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwithdraw.Location = new System.Drawing.Point(75, 193);
            this.lblwithdraw.Name = "lblwithdraw";
            this.lblwithdraw.Size = new System.Drawing.Size(105, 34);
            this.lblwithdraw.TabIndex = 2;
            this.lblwithdraw.Text = "Withdraw";
            // 
            // lblcheck_bal
            // 
            this.lblcheck_bal.AutoSize = true;
            this.lblcheck_bal.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheck_bal.Location = new System.Drawing.Point(75, 241);
            this.lblcheck_bal.Name = "lblcheck_bal";
            this.lblcheck_bal.Size = new System.Drawing.Size(150, 34);
            this.lblcheck_bal.TabIndex = 3;
            this.lblcheck_bal.Text = "Check Balance";
            // 
            // lblcus_prof
            // 
            this.lblcus_prof.AutoSize = true;
            this.lblcus_prof.Font = new System.Drawing.Font("Microsoft Himalaya", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcus_prof.Location = new System.Drawing.Point(75, 296);
            this.lblcus_prof.Name = "lblcus_prof";
            this.lblcus_prof.Size = new System.Drawing.Size(171, 34);
            this.lblcus_prof.TabIndex = 4;
            this.lblcus_prof.Text = "Customer Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log out";
            // 
            // UC_Dashboard_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcus_prof);
            this.Controls.Add(this.lblcheck_bal);
            this.Controls.Add(this.lblwithdraw);
            this.Controls.Add(this.lbldeposit);
            this.Controls.Add(this.lblregister);
            this.Name = "UC_Dashboard_Admin";
            this.Size = new System.Drawing.Size(747, 476);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregister;
        private System.Windows.Forms.Label lbldeposit;
        private System.Windows.Forms.Label lblwithdraw;
        private System.Windows.Forms.Label lblcheck_bal;
        private System.Windows.Forms.Label lblcus_prof;
        private System.Windows.Forms.Label label1;
    }
}
