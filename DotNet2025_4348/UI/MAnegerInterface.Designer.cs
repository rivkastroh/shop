namespace UI
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
            label1 = new Label();
            manegerOrderProduct = new Button();
            manegerProduct = new Button();
            manegerSale = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 60);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "שלום! מה תרצה לבצע";
            // 
            // manegerOrderProduct
            // 
            manegerOrderProduct.Location = new Point(365, 173);
            manegerOrderProduct.Name = "manegerOrderProduct";
            manegerOrderProduct.Size = new Size(133, 45);
            manegerOrderProduct.TabIndex = 1;
            manegerOrderProduct.Text = "ניהול הזמנת מוצרים";
            manegerOrderProduct.UseVisualStyleBackColor = true;
            manegerOrderProduct.Click += manegerOrderProduct_Click;
            // 
            // manegerProduct
            // 
            manegerProduct.Location = new Point(583, 173);
            manegerProduct.Name = "manegerProduct";
            manegerProduct.Size = new Size(131, 45);
            manegerProduct.TabIndex = 2;
            manegerProduct.Text = "ניהול מוצרים";
            manegerProduct.UseVisualStyleBackColor = true;
            manegerProduct.Click += manegerProduct_Click;
            // 
            // manegerSale
            // 
            manegerSale.Location = new Point(178, 173);
            manegerSale.Name = "manegerSale";
            manegerSale.Size = new Size(118, 45);
            manegerSale.TabIndex = 3;
            manegerSale.Text = "ניהול מבצעים";
            manegerSale.UseVisualStyleBackColor = true;
            manegerSale.Click += manegerSale_Click;
            // 
            // ManegerInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(manegerSale);
            Controls.Add(manegerProduct);
            Controls.Add(manegerOrderProduct);
            Controls.Add(label1);
            Name = "ManegerInterface";
            Text = "ManegerInterface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button manegerOrderProduct;
        private Button manegerProduct;
        private Button manegerSale;
    }
}