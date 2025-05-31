using LAB01;
using LAB01.Lab2;
using Lab2;
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
    public partial class frmMenu: Form
    {
        public frmMenu()
        {
            InitializeComponent();
            cboLabs.Items.AddRange(new string[]
            {
            "Lab1", "Lab2A", "Lab2B", "Lab2C",
            "Lab3A", "Lab3B", "Lab3C"
            });
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            switch (cboLabs.SelectedItem?.ToString())
            {
                case "Lab1":
                    new Form1().Show(); break;
                case "Lab2A":
                    new frmLab2A().Show(); break;
                case "Lab2B":
                    new frmLab2B().Show(); break;
                case "Lab3A":
                    new frmLab3A().Show(); break;
                case "Lab3B":
                    new frmLab3B().Show(); break;
                case "Lab3C":
                    new frmLab3C().Show(); break;
                default:
                    MessageBox.Show("請選擇表單");
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
