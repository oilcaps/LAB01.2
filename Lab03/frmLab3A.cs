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
    public partial class frmLab3A: Form
    {
        public frmLab3A()
        {
            InitializeComponent();
        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            if (cboMovie.SelectedItem != null)
            {
                MessageBox.Show("You voted for:\n" + cboMovie.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a movie series.");
            }
        }
    }
}
