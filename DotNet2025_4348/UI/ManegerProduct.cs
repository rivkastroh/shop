using BO;

namespace UI
{
    public partial class ManegerProduct : Form
    {
        public ManegerProduct()
        {
            InitializeComponent();
        }
        private BIApi.IBI _bi = BIApi.Factory.Get();

        private void addProduct_Click(object sender, EventArgs e)
        {
            Button submitButton = new Button { Text = "הוסף", Location = new Point(10, 320) };
            submitButton.Click += (s, e) =>
            {
                // לוגיקה להוספת מוצר
                try
                {
                    int barcode = int.Parse(barcodeInput.Text);
                    string name = nameInput.Text;
                    BO.Categorys category = (BO.Categorys)Enum.Parse(typeof(BO.Categorys), categoryInput.SelectedItem.ToString());
                    double price = double.Parse(priceInput.Text);
                    int quantityInStock = int.Parse(quantityInput.Text);

                    BO.Product newProduct = new BO.Product
                    {
                        Barcode = barcode,
                        Name = name,
                        Category = category,
                        Price = price,
                        QuantityInStock = quantityInStock
                    };

                    // הוספת המוצר למערכת
                    _bi.product.addProduct(newProduct);
                    // ניקוי האינפוטים
                    barcodeInput.Text = string.Empty;
                    nameInput.Text = string.Empty;
                    categoryInput.SelectedIndex = -1; // לא לבחור שום אפשרות
                    priceInput.Text = string.Empty;
                    quantityInput.Text = string.Empty;

                    // הסרת האינפוטים, הלייבלים וכפתור השליחה מהמסך
                    Controls.Remove(barcodeInput);
                    Controls.Remove(nameInput);
                    Controls.Remove(categoryInput);
                    Controls.Remove(priceInput);
                    Controls.Remove(quantityInput);
                    Controls.Remove(barcodeLabel);
                    Controls.Remove(nameLabel);
                    Controls.Remove(categoryLabel);
                    Controls.Remove(priceLabel);
                    Controls.Remove(quantityLabel);
                    Controls.Remove(submitButton);
                }
                catch (Exception ex)
                {
                    // טיפול בשגיאות, לדוגמה, אם הקלט לא תקין
                    MessageBox.Show("Error: " + ex.Message);
                }
            };
            Controls.Add(barcodeLabel);
            Controls.Add(barcodeInput);
            Controls.Add(nameLabel);
            Controls.Add(nameInput);
            Controls.Add(categoryLabel);
            Controls.Add(categoryInput);
            Controls.Add(priceLabel);
            Controls.Add(priceInput);
            Controls.Add(quantityLabel);
            Controls.Add(quantityInput);
            Controls.Add(submitButton);
        }

        private void seeAllProducts_Click(object sender, EventArgs e)
        {
            List<Product> products = _bi.product.GetProducts();
            ShowObj<BO.Product> showProd = new ShowObj<BO.Product>(products);
            showProd.Show();
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {
            Controls.Add(barcodeLabel);
            Controls.Add(barcodeInput);
            Button submitButton = new Button { Text = "עדכן", Location = new Point(20, 200) };
            Controls.Add(submitButton);
            submitButton.Click += (s, e) =>
            {
                try
                {
                    int barcode = int.Parse(barcodeInput.Text);
                    _bi.product.removeProduct(barcode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                //ניקוי מסך
                Controls.Remove(submitButton);
                Controls.Remove(barcodeInput);
                Controls.Remove(barcodeLabel);
            };

        }
        private void updateProduct_Click(object sender, EventArgs e)
        {
            Button submitButton = new Button { Text = "עדכן", Location = new Point(10, 320) };
            submitButton.Click += (s, e) =>
            {
                // לוגיקה להוספת מוצר
                try
                {
                    int barcode = int.Parse(barcodeInput.Text);
                    string name = nameInput.Text;
                    BO.Categorys category = (BO.Categorys)Enum.Parse(typeof(BO.Categorys), categoryInput.SelectedItem.ToString());
                    double price = double.Parse(priceInput.Text);
                    int quantityInStock = int.Parse(quantityInput.Text);

                    BO.Product newProduct = new BO.Product
                    {
                        Barcode = barcode,
                        Name = name,
                        Category = category,
                        Price = price,
                        QuantityInStock = quantityInStock
                    };

                    // הוספת המוצר למערכת
                    _bi.product.updateProduct(newProduct);
                    // ניקוי האינפוטים
                    barcodeInput.Text = string.Empty;
                    nameInput.Text = string.Empty;
                    categoryInput.SelectedIndex = -1; // לא לבחור שום אפשרות
                    priceInput.Text = string.Empty;
                    quantityInput.Text = string.Empty;

                    // הסרת האינפוטים, הלייבלים וכפתור השליחה מהמסך
                    Controls.Remove(barcodeInput);
                    Controls.Remove(nameInput);
                    Controls.Remove(categoryInput);
                    Controls.Remove(priceInput);
                    Controls.Remove(quantityInput);
                    Controls.Remove(barcodeLabel);
                    Controls.Remove(nameLabel);
                    Controls.Remove(categoryLabel);
                    Controls.Remove(priceLabel);
                    Controls.Remove(quantityLabel);
                    Controls.Remove(submitButton);
                }
                catch (Exception ex)
                {
                    // טיפול בשגיאות, לדוגמה, אם הקלט לא תקין
                    MessageBox.Show("Error: " + ex.Message);
                }
            };
            Controls.Add(barcodeLabel);
            Controls.Add(barcodeInput);
            Controls.Add(nameLabel);
            Controls.Add(nameInput);
            Controls.Add(categoryLabel);
            Controls.Add(categoryInput);
            Controls.Add(priceLabel);
            Controls.Add(priceInput);
            Controls.Add(quantityLabel);
            Controls.Add(quantityInput);
            Controls.Add(submitButton);


            //מלא את הערכים של שאר האינפוטים כאשר המשתמש לוחץ על מקש אנטר או יוצא מהאינפוט
            barcodeInput.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    FillInputsFromProduct();
                }
            };

            barcodeInput.Leave += (s, e) =>
            {
                FillInputsFromProduct();
            };

        }
        private void FillInputsFromProduct()
        {
            try
            {
                Product myProd = _bi.product.GetProduct(int.Parse(barcodeInput.Text));

                barcodeInput.Text = myProd.Barcode.ToString();
                nameInput.Text = myProd.Name;
                categoryInput.SelectedItem = myProd.Category.ToString(); // הנחה שהקטגוריות מתאימות
                priceInput.Text = myProd.Price.ToString();
                quantityInput.Text = myProd.QuantityInStock.ToString();
            }
            catch (Exception ex)
            {
                // טיפול בשגיאות, לדוגמה, אם הקלט לא תקין
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

