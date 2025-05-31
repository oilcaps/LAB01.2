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
    public partial class frmLab3B: Form
    {
        public frmLab3B()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = Convert.ToDouble(txtAmount.Text);
                double rate = Convert.ToDouble(txtRate.Text) / 100;
                double value10 = amount * Math.Pow(1 + rate, 10);
                lblValue2.Text = "$" + value10.ToString("F2");

                int years = 0;
                double balance = amount;
                while (balance < 1000000)
                {
                    balance *= (1 + rate);
                    years++;
                }
                lblMillion2.Text = years + " years";
            }
            catch
            {
                MessageBox.Show("insert valid num");
            }
        }
    }
}
