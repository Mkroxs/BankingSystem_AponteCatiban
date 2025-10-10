using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_TransactionHistory: UserControl
    {
        public UC_TransactionHistory()
        {
            InitializeComponent();
        }

        private void UC_TransactionHistory_Load(object sender, EventArgs e)
        {

        }

        private void dgv_cuslist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_cuslist.Rows[e.RowIndex];
            lbl_dateoftrans.Text = row.Cells["Date of Transaction"].Value?.ToString();
            lbl_transtype.Text = row.Cells["Transaction Type"].Value?.ToString();
            lbl_amount.Text = $"₱{row.Cells["Amount"].Value:N2}";
            lbl_prevbal.Text = $"₱{row.Cells["Previous Balance"].Value:N2}";
            lbl_newbal.Text = $"₱{row.Cells["New Balance"].Value:N2}";
        }
       

        private void btn_close_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.dashboard_Cus.BringToFront();
        }
    }
}
