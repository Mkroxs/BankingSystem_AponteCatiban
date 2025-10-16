using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BankingSystem_AponteCatiban.Helpers;
using BankingSystem_AponteCatiban.Models;
using Newtonsoft.Json;

namespace BankingSystem_AponteCatiban
{
    public partial class UC_TransactionHistory : UserControl
    {
        public UC_TransactionHistory()
        {
            InitializeComponent();
        }

        private void UC_TransactionHistory_Load(object sender, EventArgs e)
        {
            LoadTransactionHistory();
            ResetLabels();

            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
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

                dgv_cuslist.DataSource = customerTransactions;

                // 🧭 Make the grid read-only and locked
                dgv_cuslist.ReadOnly = true;
                dgv_cuslist.AllowUserToAddRows = false;
                dgv_cuslist.AllowUserToDeleteRows = false;
                dgv_cuslist.AllowUserToResizeRows = false;
                dgv_cuslist.RowHeadersVisible = false;
                dgv_cuslist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // 🪶 Improve headers
                dgv_cuslist.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dgv_cuslist.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
                dgv_cuslist.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgv_cuslist.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv_cuslist.EnableHeadersVisualStyles = false;

                dgv_cuslist.DefaultCellStyle.Font = new Font("Segoe UI", 9);
                dgv_cuslist.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                dgv_cuslist.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgv_cuslist.BackgroundColor = Color.White;
                dgv_cuslist.GridColor = Color.LightGray;

                dgv_cuslist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_cuslist.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // ✨ Format currency columns with ₱ sign
                if (dgv_cuslist.Columns.Contains("amount"))
                {
                    dgv_cuslist.Columns["amount"].HeaderText = "Transaction Amount";
                    dgv_cuslist.Columns["amount"].DefaultCellStyle.Format = "₱#,##0.00";
                    dgv_cuslist.Columns["amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgv_cuslist.Columns.Contains("previousBalance"))
                {
                    dgv_cuslist.Columns["previousBalance"].HeaderText = "Previous Balance";
                    dgv_cuslist.Columns["previousBalance"].DefaultCellStyle.Format = "₱#,##0.00";
                    dgv_cuslist.Columns["previousBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgv_cuslist.Columns.Contains("newBalance"))
                {
                    dgv_cuslist.Columns["newBalance"].HeaderText = "New Balance";
                    dgv_cuslist.Columns["newBalance"].DefaultCellStyle.Format = "₱#,##0.00";
                    dgv_cuslist.Columns["newBalance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                if (dgv_cuslist.Columns.Contains("type"))
                    dgv_cuslist.Columns["type"].HeaderText = "Transaction Type";

                if (dgv_cuslist.Columns.Contains("date"))
                    dgv_cuslist.Columns["date"].HeaderText = "Date";

                if (customerTransactions.Count == 0)
                    MessageBox.Show("No transactions found for your account.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dgv_cuslist_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
                LoadTransactionHistory();
        }

        public void ResetLabels()
        {
            lbl_dateoftrans.Text = "—";
            lbl_transtype.Text = "—";
            lbl_amount.Text = "₱0.00";
            lbl_prevbal.Text = "₱0.00";
            lbl_newbal.Text = "₱0.00";
        }
    }
}
