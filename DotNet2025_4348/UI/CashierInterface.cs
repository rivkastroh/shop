namespace UI
{
    public partial class CashierInterface : Form
    {
        private Form parentForm;
        private BIApi.IBI _bi = BIApi.Factory.Get();
        public CashierInterface(Form parentForm)
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Cash_FormClosed);
            this.parentForm = parentForm;
        }
        private void Cash_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }
        private void seeAllProd_Click(object sender, EventArgs e)
        {
            ShowObj<BO.Product> showObj = new ShowObj<BO.Product>(_bi.product.GetProducts());
            showObj.Show();
        }
        private void seeAllCustomer_Click(object sender, EventArgs e)
        {
            ShowObj<BO.Customer> showObj = new ShowObj<BO.Customer>(_bi.customer.GetCustomers());
            showObj.Show();
        }
        private void newAccount_Click(object sender, EventArgs e)
        {
            TextBox input = new TextBox { Location = new Point(180, 300) };
            Label label = new Label() { Text = "הקלד תז אם במועדון אחרת אנטר", Location = new Point(180, 270), Size = new Size(180, 15) };
            this.Controls.Add(input);
            this.Controls.Add(label);
            input.KeyDown += new KeyEventHandler(input_KeyDown);
        }
        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BO.Customer customer = null;
                try
                {
                    if (!string.IsNullOrWhiteSpace(((TextBox)sender).Text))
                    {
                        try
                        {
                            customer = _bi.customer.GetCustomer(int.Parse(((TextBox)sender).Text));

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw new Exception();
                        }
                    }
                    BO.Order order = new BO.Order(customer);
                    Acount acount = new Acount(order);
                    acount.Show();
                }
                catch (Exception ex)
                {
                    ((TextBox)sender).Text = "";
                }
                e.SuppressKeyPress = true;
            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            this.Controls.Add(identityLabel);
            this.Controls.Add(identityInput);
            this.Controls.Add(nameLabel);
            this.Controls.Add(nameInput);
            this.Controls.Add(addressLabel);
            this.Controls.Add(addressInput);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(phoneNumberInput);
            this.Controls.Add(this.cancel);
            //
            submitButton = new Button { Text = "הוסף", Location = new Point(580, 195) };
            submitButton.Click += SubmitButton_Click;
            this.Controls.Add(submitButton);
        }
        private void Cancel(object sender, EventArgs e)
        {
            RemoveInputs((Control)sender);
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer customer = new BO.Customer
                {
                    Identity = int.Parse(identityInput.Text),
                    Name = nameInput.Text,
                    Address = addressInput.Text,
                    PhoneNumber = phoneNumberInput.Text
                };
                _bi.customer.addCustomer(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RemoveInputs((Control)sender);
        }
        private void removeCustomer_Click(object sender, EventArgs e)
        {
            this.Controls.Add(identityLabel);
            this.Controls.Add(identityInput);
            this.Controls.Add(this.cancel);
            this.submitButton = new Button { Text = "הסר", Location = new Point(580, 195) };
            submitButton.Click += removeButton_Click;
            this.Controls.Add(submitButton);
        }
        private void removeButton_Click(Object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(identityInput.Text);
                _bi.customer.removeCustomer(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RemoveInputs((Control)sender);
        }
        private void updateCustomer_Click(object sender, EventArgs e)
        {
            this.Controls.Add(this.cancel);
            this.Controls.Add(identityLabel);
            this.Controls.Add(identityInput);
            this.Controls.Add(nameLabel);
            this.Controls.Add(nameInput);
            this.Controls.Add(addressLabel);
            this.Controls.Add(addressInput);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(phoneNumberInput);
            //
            this.submitButton = new Button { Text = "עדכן", Location = new Point(580, 195) };
            submitButton.Click += updateButton_Click;
            this.Controls.Add(submitButton);
            //מלא את הערכים של שאר האינפוטים כאשר המשתמש לוחץ על מקש אנטר או יוצא מהאינפוט
            identityInput.KeyDown += keyDownHandler;
            identityInput.Leave += leaveHandler;
        }
        private void keyDownHandler(object s,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FillInputsFromCustomer();
            }
        }
        private void leaveHandler(object s, EventArgs e)
        {
            FillInputsFromCustomer();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer customer = new BO.Customer
                {
                    Identity = int.Parse(identityInput.Text),
                    Name = nameInput.Text,
                    Address = addressInput.Text,
                    PhoneNumber = phoneNumberInput.Text
                };
                _bi.customer.updateCustomer(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RemoveInputs((Control)sender);
        }
        private void RemoveInputs(Control sender)
        {
            this.Controls.Remove(identityLabel);
            this.Controls.Remove(identityInput);
            this.Controls.Remove(nameLabel);
            this.Controls.Remove(nameInput);
            this.Controls.Remove(addressLabel);
            this.Controls.Remove(addressInput);
            this.Controls.Remove(phoneNumberLabel);
            this.Controls.Remove(phoneNumberInput);
            this.Controls.Remove((Control)sender);
            this.Controls.Remove(this.cancel);
            this.Controls.Remove(this.submitButton);
            ClearInputs();
            submitButton.Click -= updateButton_Click;
            submitButton.Click -= removeButton_Click;
            submitButton.Click -= SubmitButton_Click;
            identityInput.KeyDown -= keyDownHandler;
            identityInput.Leave -= leaveHandler;
        }
        private void FillInputsFromCustomer()
        {
            try
            {
                BO.Customer myCustomer = _bi.customer.GetCustomer(int.Parse(identityInput.Text));

                identityInput.Text = myCustomer.Identity.ToString();
                nameInput.Text = myCustomer.Name;
                addressInput.Text = myCustomer.Address;
                phoneNumberInput.Text = myCustomer.PhoneNumber;
            }
            catch (Exception ex)
            {
                // טיפול בשגיאות, לדוגמה, אם הקלט לא תקין
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearInputs()
        {
            identityInput.Text = "";
            nameInput.Text = "";
            addressInput.Text = "";
            phoneNumberInput.Text = "";
        }

    }
}
