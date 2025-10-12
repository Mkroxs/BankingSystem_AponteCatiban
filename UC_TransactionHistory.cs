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
using Newtonsoft.Json;
using System.IO;

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
            LoadTransactionHistory();
            ResetLabels();
        }

        private void dgv_cuslist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_cuslist.Rows[e.RowIndex].DataBoundItem as Transaction;
            if (row != null)
            {
                lbl_dateoftrans.Text = row.date;
                lbl_transtype.Text = row.type;
                lbl_amount.Text = $"₱{row.amount:N2}";
                lbl_prevbal.Text = $"₱{row.previousBalance:N2}";
                lbl_newbal.Text = $"₱{row.newBalance:N2}";
            }
        }
       

        private void btn_close_Click(object sender, EventArgs e)
        {
            var mainform = this.Parent as MainForm;
            mainform.dashboard_Cus.BringToFront();
            ResetLabels();
        }

        public void LoadTransactionHistory()
        {
            var mainform = this.FindForm() as MainForm;
            if (mainform == null || mainform.LoggedInCustomer == null)
                return;

            string transactionFile = Path.Combine(Application.StartupPath, "Data", "transactions.txt");

            try
            {
                if (!File.Exists(transactionFile))
                {
                    dgv_cuslist.DataSource = null;
                    return;
                }
                string jsonContent = File.ReadAllText(transactionFile);

                List<Transaction> allTransactions = JsonConvert.DeserializeObject<List<Transaction>>(jsonContent) ?? new List<Transaction>();

                var customerTransactions = allTransactions
                    .Where(t => t.customerAccountNumber == mainform.LoggedInCustomer.AccountNumber)
                    .OrderByDescending(t => t.date)
                    .ToList();

                dgv_cuslist.AutoGenerateColumns = true;
                dgv_cuslist.DataSource = customerTransactions;

                if (customerTransactions.Count == 0)
                {
                    MessageBox.Show("No transactions found for your account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
                LoadTransactionHistory(); 
        }
        private void ResetLabels()
        {
            lbl_dateoftrans.Text = "—";
            lbl_transtype.Text = "—";
            lbl_amount.Text = "₱0.00";
            lbl_prevbal.Text = "₱0.00";
            lbl_newbal.Text = "₱0.00";
        }
    }
}
