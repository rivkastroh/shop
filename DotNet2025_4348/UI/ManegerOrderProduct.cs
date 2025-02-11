using BO;

namespace UI
{
    public partial class ManegerOrderProduct : Form
    {
        public ManegerOrderProduct()
        {
            InitializeComponent();
        }
        private BIApi.IBI _bi = BIApi.Factory.Get();

        private void SeeMissProducts_Click(object sender, EventArgs e)
        {
            ShowObj<Product> showObj = new ShowObj<Product>(_bi.giveObjects.GetMissingProduct());
            showObj.Show();
        }

        private void addAmount_Click(object sender, EventArgs e)
        {
            Button submitButton = new Button { Text = "הוסף", Location = new Point(10, 320) };
            submitButton.Click += (s, e) =>
            {
                try
                {
                    int barcode = int.Parse(barcodeInput.Text);
                    int amount = int.Parse(quantityInput.Text);
                    _bi.product.addAmount(barcode, amount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }

                Controls.Remove(barcodeLabel);
                Controls.Remove(barcodeInput);
                Controls.Remove(quantityLabel);
                Controls.Remove(quantityInput);
                Controls.Remove(submitButton);
            };
            Controls.Add(barcodeLabel);
            Controls.Add(barcodeInput);
            Controls.Add(quantityLabel);
            Controls.Add(quantityInput);
            Controls.Add(submitButton);
        }
    }
}
