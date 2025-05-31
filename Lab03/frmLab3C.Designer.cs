namespace Lab03
{
    partial class frmLab3C
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
            this.lstShop = new System.Windows.Forms.ListBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnToCart = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnToShop = new System.Windows.Forms.Button();
            this.btnAddFruit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFruit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstShop
            // 
            this.lstShop.FormattingEnabled = true;
            this.lstShop.ItemHeight = 15;
            this.lstShop.Items.AddRange(new object[] {
            "Apple",
            "Banana",
            "Grape",
            "Orange",
            "Peach",
            "Pear",
            "Pineapple"});
            this.lstShop.Location = new System.Drawing.Point(94, 96);
            this.lstShop.Name = "lstShop";
            this.lstShop.Size = new System.Drawing.Size(120, 154);
            this.lstShop.TabIndex = 0;
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 15;
            this.lstCart.Location = new System.Drawing.Point(447, 96);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(120, 154);
            this.lstCart.TabIndex = 1;
            // 
            // btnToCart
            // 
            this.btnToCart.Location = new System.Drawing.Point(299, 96);
            this.btnToCart.Name = "btnToCart";
            this.btnToCart.Size = new System.Drawing.Size(75, 23);
            this.btnToCart.TabIndex = 2;
            this.btnToCart.Text = "-->";
            this.btnToCart.UseVisualStyleBackColor = true;
            this.btnToCart.Click += new System.EventHandler(this.btnToCart_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(391, 362);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(87, 44);
            this.btnCount.TabIndex = 3;
            this.btnCount.Text = "CountShop + Cart";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnToShop
            // 
            this.btnToShop.Location = new System.Drawing.Point(299, 183);
            this.btnToShop.Name = "btnToShop";
            this.btnToShop.Size = new System.Drawing.Size(75, 23);
            this.btnToShop.TabIndex = 4;
            this.btnToShop.Text = "<--";
            this.btnToShop.UseVisualStyleBackColor = true;
            this.btnToShop.Click += new System.EventHandler(this.btnToShop_Click);
            // 
            // btnAddFruit
            // 
            this.btnAddFruit.Location = new System.Drawing.Point(139, 362);
            this.btnAddFruit.Name = "btnAddFruit";
            this.btnAddFruit.Size = new System.Drawing.Size(121, 23);
            this.btnAddFruit.TabIndex = 5;
            this.btnAddFruit.Text = "AddFruit";
            this.btnAddFruit.UseVisualStyleBackColor = true;
            this.btnAddFruit.Click += new System.EventHandler(this.btnAddFruit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(546, 362);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 44);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "AddFruit";
            // 
            // txtFruit
            // 
            this.txtFruit.Location = new System.Drawing.Point(183, 297);
            this.txtFruit.Name = "txtFruit";
            this.txtFruit.Size = new System.Drawing.Size(100, 25);
            this.txtFruit.TabIndex = 9;
            // 
            // frmLab3C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFruit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddFruit);
            this.Controls.Add(this.btnToShop);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnToCart);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lstShop);
            this.Name = "frmLab3C";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLab3C_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstShop;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnToCart;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnToShop;
        private System.Windows.Forms.Button btnAddFruit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFruit;
    }
}