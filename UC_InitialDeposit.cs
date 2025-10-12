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
            InitializeDenominationEvents();


        }
        private void CalculateDepositTotal()
        {
            decimal total = 0;
            total += ParseDecimal(txt1000.Text) * 1000;
            total += ParseDecimal(txt500.Text) * 500;
            total += ParseDecimal(txt200.Text) * 200;
            total += ParseDecimal(txt100.Text) * 100;
            total += ParseDecimal(txt50.Text) * 50;
            total += ParseDecimal(txt20.Text) * 20;
            total += ParseDecimal(txt10.Text) * 10;
            total += ParseDecimal(txt5.Text) * 5;
            total += ParseDecimal(txt1.Text) * 1;

            totalAmount = total;
            lbl_totalamount.Text = $"₱{totalAmount:N2}";
        }

        private int ParseDecimal(string text)
        {
            if (int.TryParse(text, out int value) && value >= 0)
                return value;
            return 0;
        }

        private void ClearDenominations()
        {
            txt1000.Text = "";
            txt500.Text = "";
            txt200.Text = "";
            txt100.Text = "";
            txt50.Text = "";
            txt20.Text = "";
            txt10.Text = "";
            txt5.Text = "";
            txt1.Text = "";
            lbl_totalamount.Text = "₱0.00";
        }

        private void InitializeDenominationEvents()
        {
            TextBox[] denominationTextBoxes = new TextBox[]
            {
        txt1000, txt500, txt200, txt100, txt50, txt20, txt10, txt5, txt1
            };

            foreach (var txt in denominationTextBoxes)
            {
                txt.TextChanged += (s, e) => CalculateDepositTotal();
                txt.KeyPress += (s, e) =>
                {
                    e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
                };
                txt.Enter += (s, e) => (s as TextBox)?.Clear();
            }
        }

        private void UC_InitialDeposit_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            OnConfirm?.Invoke(totalAmount); 
            totalAmount = 0;
            lbl_totalamount.Text = "₱0.00";
            ClearDenominations();
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

        private void btn_1_Click(object sender, EventArgs e)
        {

        }

        private void txt1000_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt1000.Text.Length >= 6)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt500_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt500.Text.Length >= 6)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt200_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt200.Text.Length >= 6)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt100_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt100.Text.Length >= 6)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt50.Text.Length >= 6)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt20_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt20.Text.Length >= 6)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt5.Text.Length >= 6)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt10.Text.Length >= 6)
            {
                e.Handled = true;
                return;
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt1.Text.Length >= 6)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
