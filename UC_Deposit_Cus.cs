using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Models;
using BankingSystem_AponteCatiban.Helpers;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_Deposit_Cus: UserControl
    {

        decimal totalAmount = 0;
        public event Action<decimal> OnConfirm;

        private void setValue (object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            
            if (decimal.TryParse(btn.Text, out decimal value))
            {
                totalAmount += value;
                lbl_totalamount.Text = $"₱{totalAmount:N2}";
            }
        }

        public UC_Deposit_Cus()
        {
            InitializeComponent();

            btn_1000.Click += setValue;
            btn_500.Click += setValue;
            btn_200.Click += setValue;
            btn_100.Click += setValue;
            btn_50.Click += setValue;
            btn_20.Click += setValue;
            btn_10.Click += setValue;
            btn_5.Click += setValue;
            btn_1.Click += setValue;
        }

        private void btn_1000_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_totalamount_Click(object sender, EventArgs e)
        {

        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            OnConfirm?.Invoke(totalAmount);
            totalAmount = 0;
            lbl_totalamount.Text = "₱0.00";
        }

        private void UC_Deposit_Cus_Load(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            totalAmount = 0;
            lbl_totalamount.Text = "₱0.00";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.dashboard_Cus.BringToFront();
        }
      
        private void btn_500_Click(object sender, EventArgs e)
        {
        }

        private void btn_200_Click(object sender, EventArgs e)
        {
        }

        private void btn_100_Click(object sender, EventArgs e)
        {
        }

        private void btn_50_Click(object sender, EventArgs e)
        {
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
        }
    }
}
