using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmLab2A : Form
    {
        private int price;
        private string payment;

        public frmLab2A()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int qty = Convert.ToInt32(txtQty.Text);
                int total = qty * price;
                label1.Text = $"Total: ${total} via {payment}";
            }
            catch
            {
                MessageBox.Show("請輸入有效的數量");
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}