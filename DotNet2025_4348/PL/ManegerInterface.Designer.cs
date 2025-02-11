namespace PL
{
    partial class ManegerInterface
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
            this.manegerProduct = new System.Windows.Forms.Button();
            this.manegerOrderProduct = new System.Windows.Forms.Button();
            this.manegerSale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manegerProduct
            // 
            this.manegerProduct.Location = new System.Drawing.Point(593, 152);
            this.manegerProduct.Name = "manegerProduct";
            this.manegerProduct.Size = new System.Drawing.Size(113, 53);
            this.manegerProduct.TabIndex = 0;
            this.manegerProduct.Text = "ניהול מוצרים";
            this.manegerProduct.UseVisualStyleBackColor = true;
            this.manegerProduct.Click += new System.EventHandler(this.manegerProduct_Click);
            // 
            // manegerOrderProduct
            // 
            this.manegerOrderProduct.Location = new System.Drawing.Point(340, 152);
            this.manegerOrderProduct.Name = "manegerOrderProduct";
            this.manegerOrderProduct.Size = new System.Drawing.Size(111, 53);
            this.manegerOrderProduct.TabIndex = 1;
            this.manegerOrderProduct.Text = "ניהול הזמנת מוצרים";
            this.manegerOrderProduct.UseVisualStyleBackColor = true;
            // 
            // manegerSale
            // 
            this.manegerSale.Location = new System.Drawing.Point(109, 152);
            this.manegerSale.Name = "manegerSale";
            this.manegerSale.Size = new System.Drawing.Size(108, 53);
            this.manegerSale.TabIndex = 2;
            this.manegerSale.Text = "ניהול מבצעים";
            this.manegerSale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "שלום! מה תרצה לבצע";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManegerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manegerSale);
            this.Controls.Add(this.manegerOrderProduct);
            this.Controls.Add(this.manegerProduct);
            this.Name = "ManegerInterface";
            this.Text = "ManegerInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manegerProduct;
        private System.Windows.Forms.Button manegerOrderProduct;
        private System.Windows.Forms.Button manegerSale;
        private System.Windows.Forms.Label label1;
    }
}