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
    public partial class MainForm : Form
    {
        private Font originalFont;
        private Color originalForeColor;
        private Color originalBackColor;

        public MainForm()
        {
            InitializeComponent();
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;

            this.Load += MainForm_Load;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            originalFont = label3.Font;
            originalForeColor = label3.ForeColor;
            originalBackColor = label3.BackColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = originalForeColor;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.SkyBlue;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UC_Registration registration = new UC_Registration();
            this.Controls.Add(registration);
            registration.Dock = DockStyle.Fill;
            registration.BringToFront();
        }
    }
}
