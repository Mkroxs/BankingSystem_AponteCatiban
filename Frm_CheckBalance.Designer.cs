namespace BankingSystem_AponteCatiban
{
    partial class Frm_CheckBalance
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAccountInput = new System.Windows.Forms.Panel();
            this.tbxAccountNumber = new System.Windows.Forms.TextBox();
            this.lbl_accnum = new System.Windows.Forms.Label();
            this.lbl_accname = new System.Windows.Forms.Label();
            this.lbl_rembal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelAccountInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAccountInput
            // 
            this.panelAccountInput.Controls.Add(this.btnClose);
            this.panelAccountInput.Controls.Add(this.lbl_rembal);
            this.panelAccountInput.Controls.Add(this.lbl_accname);
            this.panelAccountInput.Controls.Add(this.lbl_accnum);
            this.panelAccountInput.Controls.Add(this.tbxAccountNumber);
            this.panelAccountInput.Location = new System.Drawing.Point(114, 52);
            this.panelAccountInput.Name = "panelAccountInput";
            this.panelAccountInput.Size = new System.Drawing.Size(462, 200);
            this.panelAccountInput.TabIndex = 0;
            // 
            // tbxAccountNumber
            // 
            this.tbxAccountNumber.Location = new System.Drawing.Point(106, 22);
            this.tbxAccountNumber.Name = "tbxAccountNumber";
            this.tbxAccountNumber.Size = new System.Drawing.Size(258, 20);
            this.tbxAccountNumber.TabIndex = 0;
            this.tbxAccountNumber.TextChanged += new System.EventHandler(this.tbxAccountNumber_TextChanged);
            this.tbxAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAccountNumber_KeyPress);
            // 
            // lbl_accnum
            // 
            this.lbl_accnum.AutoSize = true;
            this.lbl_accnum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_accnum.Location = new System.Drawing.Point(110, 64);
            this.lbl_accnum.Name = "lbl_accnum";
            this.lbl_accnum.Size = new System.Drawing.Size(143, 19);
            this.lbl_accnum.TabIndex = 1;
            this.lbl_accnum.Text = "Account Number";
            // 
            // lbl_accname
            // 
            this.lbl_accname.AutoSize = true;
            this.lbl_accname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_accname.Location = new System.Drawing.Point(112, 92);
            this.lbl_accname.Name = "lbl_accname";
            this.lbl_accname.Size = new System.Drawing.Size(128, 19);
            this.lbl_accname.TabIndex = 2;
            this.lbl_accname.Text = "Account Name";
            // 
            // lbl_rembal
            // 
            this.lbl_rembal.AutoSize = true;
            this.lbl_rembal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_rembal.Location = new System.Drawing.Point(112, 118);
            this.lbl_rembal.Name = "lbl_rembal";
            this.lbl_rembal.Size = new System.Drawing.Size(163, 19);
            this.lbl_rembal.TabIndex = 3;
            this.lbl_rembal.Text = "Remaining Balance";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(298, 152);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frm_CheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAccountInput);
            this.Name = "Frm_CheckBalance";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Frm_CheckBalance_Load);
            this.panelAccountInput.ResumeLayout(false);
            this.panelAccountInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccountInput;
        private System.Windows.Forms.Label lbl_accnum;
        private System.Windows.Forms.TextBox tbxAccountNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl_rembal;
        private System.Windows.Forms.Label lbl_accname;
    }
}