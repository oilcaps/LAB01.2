using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LAB01.Lab2
{
    public partial class frmLab2B: Form
    {
        public frmLab2B()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Sunny.Visible = false;
            Cloudy.Visible = true;
            Rainy.Visible = false;
            Snowy.Visible = false;
            label1.Visible = true;
            label1.Text = "It's going to be a Cloudy day today, " + textBox1.Text + ".";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Sunny.Visible = false;
            Cloudy.Visible = false;
            Rainy.Visible = true;
            Snowy.Visible = false;
            label1.Visible = true;
            label1.Text = "It's going to be a Rainy day today, " + textBox1.Text + ".";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Sunny.Visible = false;
            Cloudy.Visible = false;
            Rainy.Visible = false;
            Snowy.Visible = true;
            label1.Visible = true;
            label1.Text = "It's going to be a Snowy day today, " + textBox1.Text + ".";
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Sunny.Visible = true;
            Cloudy.Visible = false;
            Rainy.Visible = false;
            Snowy.Visible = false;
            label1.Visible = true;
            label1.Text = "It's going to be a sunny day today, " + textBox1.Text + ".";
        }


        private void frmLab2B_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
