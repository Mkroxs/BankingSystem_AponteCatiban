using BankingSystem_AponteCatiban;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_InitialDeposit : UserControl
    {
        decimal totalAmount = 0;
        public event Action<decimal> OnConfirm;

        private void setValue(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;


            if (decimal.TryParse(btn.Text, out decimal value))
            {
                totalAmount += value;
                lbl_totalamount.Text = $"₱{totalAmount:N2}";
            }
        }
        public UC_InitialDeposit()
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

        private void UC_InitialDeposit_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            OnConfirm?.Invoke(totalAmount); 
            totalAmount = 0;
            lbl_totalamount.Text = "₱0.00";
            this.Hide();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            totalAmount = 0;
            lbl_totalamount.Text = "₱0";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
    
            this.Hide();
            
        }

        private void lbl_totalamount_Click(object sender, EventArgs e)
        {

        }
    }
}
