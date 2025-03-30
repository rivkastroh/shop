using BO;

namespace UI
{
    public partial class ManegerSale : Form
    {
        private BIApi.IBI _bi = BIApi.Factory.Get();
        public ManegerSale()
        {
            InitializeComponent();
        }

        private void seeAllSale_Click(object sender, EventArgs e)
        {
            IEnumerable<BO.Sale> sales = _bi.sale.getAllSale();
            ShowObj<BO.Sale> showSales = new ShowObj<BO.Sale>(sales);
            showSales.Show();
        }
        private void addSale_Click(object sender, EventArgs e)
        {
            addControls();
            Button submitButton = new Button { Text = "הוסף", Location = new Point(310, 320) };
            submitButton.Click += (s, e) =>
            {
                try
                {
                    // יצירת אובייקט Sale
                    Sale newSale = new Sale
                    {
                        Id = int.Parse(txtId.Text),
                        Barcode = int.Parse(txtBarcode.Text),
                        AmountGetSale = int.Parse(txtAmountGetSale.Text),
                        TotalPrice = _bi.product.GetProduct(int.Parse(txtBarcode.Text)).Price- double.Parse(txtDiscount.Text),
                        discount = double.Parse(txtDiscount.Text),
                        IntendedAllCustomers = chkIntendedAllCustomers.Checked,
                        StartSale = dtpStartSale.Value,
                        FinishSale = dtpFinishSale.Value
                    };
                    _bi.sale.addSale(newSale);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                // מחיקת תוכן האינפוטים
                txtId.Clear();
                txtBarcode.Clear();
                txtAmountGetSale.Clear();
                txtDiscount.Clear();
                chkIntendedAllCustomers.Checked = false;
                dtpStartSale.Value = DateTime.Now; // או תאריך אחר שאתה רוצה לאתחל
                dtpFinishSale.Value = DateTime.Now; // או תאריך אחר שאתה רוצה לאתחל

                // הסרת הפקדים מהמסך
                this.Controls.Remove(txtId);
                this.Controls.Remove(txtBarcode);
                this.Controls.Remove(txtAmountGetSale);
                this.Controls.Remove(txtDiscount);
                this.Controls.Remove(chkIntendedAllCustomers);
                this.Controls.Remove(dtpStartSale);
                this.Controls.Remove(dtpFinishSale);
                this.Controls.Remove(submitButton);
                // הסרת הלייבלים מהמסך
                this.Controls.Remove(lblId);
                this.Controls.Remove(lblBarcode);
                this.Controls.Remove(lblAmountGetSale);
                this.Controls.Remove(lblDiscount);
                this.Controls.Remove(lblIntendedAllCustomers);
                this.Controls.Remove(lblStartSale);
                this.Controls.Remove(lblFinishSale);
            };
            this.Controls.Add(submitButton);
        }
        private void updateSale_Click(object sender, EventArgs e)
        {
            addControls();
            Button submitButton = new Button { Text = "עדכן", Location = new Point(310, 320) };
            submitButton.Click += (s, e) =>
            {
                try
                {
                    // יצירת אובייקט Sale
                    Sale newSale = new Sale
                    {
                        Id = int.Parse(txtId.Text),
                        Barcode = int.Parse(txtBarcode.Text),
                        AmountGetSale = int.Parse(txtAmountGetSale.Text),
                        TotalPrice = _bi.product.GetProduct(int.Parse(txtBarcode.Text)).Price - double.Parse(txtDiscount.Text),
                        discount = double.Parse(txtDiscount.Text),
                        IntendedAllCustomers = chkIntendedAllCustomers.Checked,
                        StartSale = dtpStartSale.Value,
                        FinishSale = dtpFinishSale.Value
                    };
                    _bi.sale.updateSale(newSale);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                // מחיקת תוכן האינפוטים
                txtId.Clear();
                txtBarcode.Clear();
                txtAmountGetSale.Clear();
                txtDiscount.Clear();
                chkIntendedAllCustomers.Checked = false;
                dtpStartSale.Value = DateTime.Now; // או תאריך אחר שאתה רוצה לאתחל
                dtpFinishSale.Value = DateTime.Now; // או תאריך אחר שאתה רוצה לאתחל
                txtId.KeyDown -= txtIdKeyDown;
                txtId.Leave -= txtIdLeave;
                // הסרת הפקדים מהמסך
                this.Controls.Remove(txtId);
                this.Controls.Remove(txtBarcode);
                this.Controls.Remove(txtAmountGetSale);
                this.Controls.Remove(txtDiscount);
                this.Controls.Remove(chkIntendedAllCustomers);
                this.Controls.Remove(dtpStartSale);
                this.Controls.Remove(dtpFinishSale);
                this.Controls.Remove(submitButton);
                // הסרת הלייבלים מהמסך
                this.Controls.Remove(lblId);
                this.Controls.Remove(lblBarcode);
                this.Controls.Remove(lblAmountGetSale);
                this.Controls.Remove(lblDiscount);
                this.Controls.Remove(lblIntendedAllCustomers);
                this.Controls.Remove(lblStartSale);
                this.Controls.Remove(lblFinishSale);
            };
            this.Controls.Add(submitButton);
            txtId.KeyDown += txtIdKeyDown;
            txtId.Leave += txtIdLeave;
        }
        private void txtIdKeyDown(object s, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillInputsFromSale();
            }
        }
        private void txtIdLeave(object s, EventArgs e)
        {
            FillInputsFromSale();
        }
        private void FillInputsFromSale()
        {
            try
            {
                Sale sale = _bi.sale.getSale(int.Parse(txtId.Text));

                txtId.Text = sale.Id.ToString();
                txtBarcode.Text = sale.Barcode.ToString();
                txtAmountGetSale.Text = sale.AmountGetSale.ToString();
                txtDiscount.Text = sale.discount.ToString("F2");
                chkIntendedAllCustomers.Checked = sale.IntendedAllCustomers;
                dtpStartSale.Text = sale.StartSale.ToString("yyyy-MM-dd"); // פורמט תאריך
                dtpFinishSale.Text = sale.FinishSale.ToString("yyyy-MM-dd"); // פורמט תאריך.ToString();
            }
            catch (Exception ex)
            {
                // טיפול בשגיאות, לדוגמה, אם הקלט לא תקין
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void addControls()
        {
            this.Controls.Add(lblId);
            this.Controls.Add(lblBarcode);
            this.Controls.Add(lblAmountGetSale);
            this.Controls.Add(lblDiscount);
            this.Controls.Add(lblIntendedAllCustomers);
            this.Controls.Add(lblStartSale);
            this.Controls.Add(lblFinishSale);
            this.Controls.Add(txtId);
            this.Controls.Add(txtBarcode);
            this.Controls.Add(txtAmountGetSale);
            this.Controls.Add(txtDiscount);
            this.Controls.Add(chkIntendedAllCustomers);
            this.Controls.Add(dtpStartSale);
            this.Controls.Add(dtpFinishSale);
        }
        private void removeSale_Click(object sender, EventArgs e)
        {
            this.Controls.Add(lblId);
            this.Controls.Add(txtId);
            Button submitButton = new Button { Text = "הסר", Location = new Point(310, 320) };
            submitButton.Click += (s, e) =>
            {
                int id = int.Parse(txtId.Text);
                _bi.sale.removeSale(id);

                Controls.Remove(submitButton);
                Controls.Remove(lblId);
                Controls.Remove(txtId);
            };
            this.Controls.Add(submitButton);
        }
    }
}
