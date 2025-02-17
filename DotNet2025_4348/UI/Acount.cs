namespace UI
{
    public partial class Acount : Form
    {
        public Acount(BO.Order order)
        {
            this.order = order;
            InitializeComponent();
        }
        private BIApi.IBI _bi = BIApi.Factory.Get();
        BO.Order order;
        

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.addProdOrder();
            }
        }
        private void addProd_Click(object sender, EventArgs e)
        {
            this.addProdOrder();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenu = new ContextMenuStrip();

                // הוספת אופציות לתפריט
                ToolStripMenuItem viewProductsItem = new ToolStripMenuItem("לראות את כל המוצרים");
                viewProductsItem.Click += ViewProducts_Click;
                contextMenu.Items.Add(viewProductsItem);

                ToolStripMenuItem endSessionItem = new ToolStripMenuItem("לסיום ותשלום");
                endSessionItem.Click += EndSession_Click;
                contextMenu.Items.Add(endSessionItem);

                // הוספת אופציה חדשה
                ToolStripMenuItem viewCollectedItemsItem = new ToolStripMenuItem("לראות את המוצרים שנאספו עד עכשיו");
                viewCollectedItemsItem.Click += ViewCollectedItems_Click;
                contextMenu.Items.Add(viewCollectedItemsItem);

                contextMenu.Show(this, e.Location);
            }

        }
        // פונקציה שתופעל כאשר נבחרת האופציה "לראות את כל המוצרים"
        private void ViewProducts_Click(object sender, EventArgs e)
        {
            ShowObj<BO.Product> showObj = new ShowObj<BO.Product>(_bi.product.GetProducts());
            showObj.Show();
        }

        // פונקציה שתופעל כאשר נבחרת האופציה "לסיים חשבון"
        private void EndSession_Click(object sender, EventArgs e)
        {
            endAcount();
        }

        // פונקציה שתופעל כאשר נבחרת האופציה "לראות את המוצרים שנאספו עד עכשיו"
        private void ViewCollectedItems_Click(object sender, EventArgs e)
        {
            ShowObj<BO.ProductOrder> showObj = new ShowObj<BO.ProductOrder>(this.order.Products);
            showObj.Show();
        }

        private void finishAcount_Click(object sender, EventArgs e)
        {
            endAcount();
        }

        private void addProdOrder()
        {
            try
            {
                BO.ProductOrder p = _bi.order.isExixt(order,int.Parse(this.inputBarcode.Text));
                if (p!=null)
                {
                    p.Amount += 1;
                }
                else
                {
                    BO.ProductOrder productOrder = new BO.ProductOrder(int.Parse(this.inputBarcode.Text));
                    _bi.order.addProduct(order, productOrder);
                }
                this.inputBarcode.Text = "";
                double sum = _bi.order.orderTermination(this.order);
                this.sum.Text = $"סכום כולל: {sum} ש\"ח";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void endAcount()
        {
            FinishAcount finishAcount = new FinishAcount(this.order,this);
            finishAcount.Show();
            this.Hide();
        }

    }
}
