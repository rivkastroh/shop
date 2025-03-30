namespace UI
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
            addProduct = new Button();
            updateProduct = new Button();
            removeProduct = new Button();
            seeAllProducts = new Button();
            SuspendLayout();
            //add
            categoryInput.Items.AddRange(new string[] { "emona","tfila","havatHashem", "nisayon", "havatYisrahel" });
            // 
            // addProduct
            // 
            addProduct.Location = new Point(660, 57);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(94, 52);
            addProduct.TabIndex = 0;
            addProduct.Text = "להוסיף מוצר";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // updateProduct
            // 
            updateProduct.Location = new Point(500, 57);
            updateProduct.Name = "updateProduct";
            updateProduct.Size = new Size(99, 52);
            updateProduct.TabIndex = 1;
            updateProduct.Text = "לעדכן מוצר";
            updateProduct.UseVisualStyleBackColor = true;
            updateProduct.Click += updateProduct_Click;
            // 
            // removeProduct
            // 
            removeProduct.Location = new Point(310, 57);
            removeProduct.Name = "removeProduct";
            removeProduct.Size = new Size(113, 52);
            removeProduct.TabIndex = 2;
            removeProduct.Text = "להסיר מוצר";
            removeProduct.UseVisualStyleBackColor = true;
            removeProduct.Click += removeProduct_Click;
            // 
            // seeAllProducts
            // 
            seeAllProducts.Location = new Point(145, 57);
            seeAllProducts.Name = "seeAllProducts";
            seeAllProducts.Size = new Size(128, 52);
            seeAllProducts.TabIndex = 3;
            seeAllProducts.Text = "לראות את כלל המוצרים";
            seeAllProducts.UseVisualStyleBackColor = true;
            seeAllProducts.Click += seeAllProducts_Click;
            // 
            // ManegerProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(seeAllProducts);
            Controls.Add(removeProduct);
            Controls.Add(updateProduct);
            Controls.Add(addProduct);
            Name = "ManegerProduct";
            Text = "ניהול מוצרים";
            ResumeLayout(false);
        }

        #endregion

        private Button addProduct;
        private Button updateProduct;
        private Button removeProduct;
        private Button seeAllProducts;

        Label barcodeLabel = new Label { Text = "ברקוד", Location = new Point(10, 170) };
        TextBox barcodeInput = new TextBox { Location = new Point(130, 170) };

        Label nameLabel = new Label { Text = "שם", Location = new Point(10, 200) };  // שינוי מיקום
        TextBox nameInput = new TextBox { Location = new Point(130, 200) };

        Label categoryLabel = new Label { Text = "קטגוריה", Location = new Point(10, 230) };
        ComboBox categoryInput = new ComboBox { Location = new Point(130, 230) };

        Label priceLabel = new Label { Text = "מחיר", Location = new Point(10, 260) };  // שינוי מיקום
        TextBox priceInput = new TextBox { Location = new Point(130, 260) };

        Label quantityLabel = new Label { Text = "כמות במלאי", Location = new Point(10, 290) };  // שינוי מיקום
        TextBox quantityInput = new TextBox { Location = new Point(130, 290) };
        //         מה שנמחק בצורה לא ברורה   categoryInput.Items.AddRange(new string[] { "emona","tfila","havatHashem" });

    }
}