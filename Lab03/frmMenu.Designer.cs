namespace Lab03
{
    partial class frmMenu
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
            this.cboLabs = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboLabs
            // 
            this.cboLabs.FormattingEnabled = true;
            this.cboLabs.Location = new System.Drawing.Point(203, 166);
            this.cboLabs.Name = "cboLabs";
            this.cboLabs.Size = new System.Drawing.Size(121, 23);
            this.cboLabs.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(221, 242);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(197, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "SDP Labs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboLabs);
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLabs;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
    }
}