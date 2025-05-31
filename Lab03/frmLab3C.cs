using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class frmLab3C: Form
    {
        public frmLab3C()
        {
            InitializeComponent();
        }

        private void frmLab3C_Load(object sender, EventArgs e)
        {
            lstShop.Items.AddRange(new string[] { "Apple", "Banana", "Grape", "Orange", "Peach", "Pear", "Pineapple" });
        }

        private void btnAddFruit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFruit.Text))
                lstShop.Items.Add(txtFruit.Text);
        }

        private void btnToCart_Click(object sender, EventArgs e)
        {
            if (lstShop.SelectedItem != null)
            {
                lstCart.Items.Add(lstShop.SelectedItem);
                lstShop.Items.Remove(lstShop.SelectedItem);
            }
        }

        private void btnToShop_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedItem != null)
            {
                lstShop.Items.Add(lstCart.SelectedItem);
                lstCart.Items.Remove(lstCart.SelectedItem);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Shop: {lstShop.Items.Count}, Cart: {lstCart.Items.Count}");
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            foreach (var item in lstCart.Items)
            {
                lstShop.Items.Add(item);
            }
            lstCart.Items.Clear();
        }
    }
    
}
