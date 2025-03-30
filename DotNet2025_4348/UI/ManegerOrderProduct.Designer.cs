namespace UI
{
    partial class ManegerOrderProduct
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
            SeeMissProducts = new Button();
            addAmount = new Button();
            SuspendLayout();
            // 
            // SeeMissProducts
            // 
            SeeMissProducts.Location = new Point(320, 84);
            SeeMissProducts.Name = "SeeMissProducts";
            SeeMissProducts.Size = new Size(138, 42);
            SeeMissProducts.TabIndex = 0;
            SeeMissProducts.Text = "לראות מוצרים חסרים";
            SeeMissProducts.UseVisualStyleBackColor = true;
            SeeMissProducts.Click += SeeMissProducts_Click;
            // 
            // addAmount
            // 
            addAmount.Location = new Point(320, 220);
            addAmount.Name = "addAmount";
            addAmount.Size = new Size(138, 42);
            addAmount.TabIndex = 1;
            addAmount.Text = "הוסף כמות למוצר";
            addAmount.UseVisualStyleBackColor = true;
            addAmount.Click += addAmount_Click;
            // 
            // ManegerOrderProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addAmount);
            Controls.Add(SeeMissProducts);
            Name = "ManegerOrderProduct";
            Text = "הזמנת מוצרים";
            ResumeLayout(false);
        }

        #endregion

        private Button SeeMissProducts;
        private Button addAmount;

        Label barcodeLabel = new Label { Text = "ברקוד", Location = new Point(10, 170) };
        TextBox barcodeInput = new TextBox { Location = new Point(130, 170) };
        Label quantityLabel = new Label { Text = "כמות להוספה", Location = new Point(10, 200) };
        TextBox quantityInput = new TextBox { Location = new Point(130, 200) };
    }
}