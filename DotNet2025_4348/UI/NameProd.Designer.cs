using BIApi;
using BO;
using System;

namespace UI
{
    partial class NameProd
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
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            FlowLayoutPanel flowLayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown
            };

            Dictionary<BO.Categorys, List<BO.Product>> categoryDict = new Dictionary<BO.Categorys, List<BO.Product>>();
            // ארגן את המוצרים לפי קטגוריות
            foreach (var order in _productOrders)
            {
                var product = _bi.product.GetProduct(order.Barcode);
                if (product != null)
                {
                    if (!categoryDict.ContainsKey(product.Category))
                    {
                        categoryDict[product.Category] = new List<BO.Product>();
                    }
                    categoryDict[product.Category].Add(product);
                }
            }

            Random random = new Random();

            // הוסף את הקטגוריות והמוצרים ל-flowLayout
            foreach (var category in categoryDict.Keys.OrderBy(c => c)) // מיין את הקטגוריות
            {
                string categoryName = category switch
                {
                    Categorys.emona => "אמונה",
                    Categorys.tfila => "תפילה",
                    Categorys.havatHashem => "אהבת השם",
                    Categorys.nisayon=>"נסיונות",
                    Categorys.havatYisrahel=>"אהבת ישראל",
                    _ => category.ToString() // המרה ל-string עבור קטגוריות אחרות
                };
                var categoryLabel = new Label
                {

                    Text = categoryName,
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(5)
                };
                flowLayout.Controls.Add(categoryLabel);
                foreach (var order in categoryDict[category])
                {
                    BO.Product product = _bi.product.GetProduct(order.Barcode);
                    if (product != null)
                    {
                        var label = new Label
                        {
                            Text = product.Name,
                            AutoSize = true,
                            Margin = new Padding(5),
                            ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)), // צבעים אקראיים
                            Font = new Font("Arial", 14, FontStyle.Bold)
                        };
                        flowLayout.Controls.Add(label);
                    }
                }
                // הוסף רווח בין קטגוריות
                flowLayout.Controls.Add(new Label { Text = "", AutoSize = true }); // שורת רווח
                flowLayout.Controls.Add(new Label { Text = "", AutoSize = true }); // שורת רווח
            }

            this.Controls.Add(flowLayout);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "המשפטים שלך";

        }

        #endregion
    }
}