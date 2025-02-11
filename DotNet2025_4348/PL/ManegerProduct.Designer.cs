namespace PL
{
    partial class ManegerProduct
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
            this.updateProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.printProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // updateProduct
            // 
            this.updateProduct.Location = new System.Drawing.Point(645, 38);
            this.updateProduct.Name = "updateProduct";
            this.updateProduct.Size = new System.Drawing.Size(111, 43);
            this.updateProduct.TabIndex = 0;
            this.updateProduct.Text = "לעדכן מוצר";
            this.updateProduct.UseVisualStyleBackColor = true;
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(458, 38);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(105, 42);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "להוסיף מוצר";
            this.addProduct.UseVisualStyleBackColor = true;
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(277, 37);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(97, 42);
            this.deleteProduct.TabIndex = 2;
            this.deleteProduct.Text = "להסיר מוצר";
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // printProducts
            // 
            this.printProducts.Location = new System.Drawing.Point(92, 38);
            this.printProducts.Name = "printProducts";
            this.printProducts.Size = new System.Drawing.Size(105, 41);
            this.printProducts.TabIndex = 3;
            this.printProducts.Text = "לראות את כלל המוצרים";
            this.printProducts.UseVisualStyleBackColor = true;
            // 
            // ManegerProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printProducts);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.updateProduct);
            this.Name = "ManegerProduct";
            this.Text = "ManegerProduct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.Button printProducts;
    }
}