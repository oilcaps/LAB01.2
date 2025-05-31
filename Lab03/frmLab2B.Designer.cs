namespace LAB01.Lab2
{
    partial class frmLab2B
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLab2B));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Sunny = new System.Windows.Forms.PictureBox();
            this.Snowy = new System.Windows.Forms.PictureBox();
            this.Cloudy = new System.Windows.Forms.PictureBox();
            this.Rainy = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rainy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(128, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "                                                ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your name here";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(353, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 25);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(45, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 155);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cloudy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Rainy";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 19);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Snowy";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 95);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(68, 19);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Sunny";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Sunny
            // 
            this.Sunny.Image = global::Lab03.Properties.Resources.sky;
            this.Sunny.Location = new System.Drawing.Point(528, 258);
            this.Sunny.Name = "Sunny";
            this.Sunny.Size = new System.Drawing.Size(100, 71);
            this.Sunny.TabIndex = 10;
            this.Sunny.TabStop = false;
            // 
            // Snowy
            // 
            this.Snowy.Image = global::Lab03.Properties.Resources.snow263;
            this.Snowy.Location = new System.Drawing.Point(373, 258);
            this.Snowy.Name = "Snowy";
            this.Snowy.Size = new System.Drawing.Size(100, 71);
            this.Snowy.TabIndex = 9;
            this.Snowy.TabStop = false;
            // 
            // Cloudy
            // 
            this.Cloudy.Image = global::Lab03.Properties.Resources.cloud316;
            this.Cloudy.Location = new System.Drawing.Point(373, 158);
            this.Cloudy.Name = "Cloudy";
            this.Cloudy.Size = new System.Drawing.Size(100, 67);
            this.Cloudy.TabIndex = 8;
            this.Cloudy.TabStop = false;
            // 
            // Rainy
            // 
            this.Rainy.Image = global::Lab03.Properties.Resources.raindrops2;
            this.Rainy.InitialImage = ((System.Drawing.Image)(resources.GetObject("Rainy.InitialImage")));
            this.Rainy.Location = new System.Drawing.Point(528, 158);
            this.Rainy.Name = "Rainy";
            this.Rainy.Size = new System.Drawing.Size(100, 67);
            this.Rainy.TabIndex = 7;
            this.Rainy.TabStop = false;
            // 
            // frmLab2B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sunny);
            this.Controls.Add(this.Snowy);
            this.Controls.Add(this.Cloudy);
            this.Controls.Add(this.Rainy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLab2B";
            this.Text = "Weather Report";
            this.Load += new System.EventHandler(this.frmLab2B_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rainy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.PictureBox Rainy;
        private System.Windows.Forms.PictureBox Cloudy;
        private System.Windows.Forms.PictureBox Snowy;
        private System.Windows.Forms.PictureBox Sunny;
    }
}