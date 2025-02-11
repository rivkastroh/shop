namespace PL
{
    partial class ManegerSale
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
            this.label1 = new System.Windows.Forms.Label();
            this.addProduct = new System.Windows.Forms.Button();
            this.updateProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ניהול מוצרים";
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(590, 152);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(75, 23);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "הוספה";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // updateProduct
            // 
            this.updateProduct.Location = new System.Drawing.Point(399, 151);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(75, 23);
            this.updateProduct.TabIndex = 2;
            this.updateProduct.Text = "עדכון";
            this.updateProduct.UseVisualStyleBackColor = true;
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(216, 150);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.deleteProduct.TabIndex = 3;
            this.deleteProduct.Text = "הסרה";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // ManegerSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.updateProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.label1);
            this.Name = "ManegerSale";
            this.Text = "ManegerSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button updateProduct;
        private System.Windows.Forms.Button deleteProduct;
    }
}