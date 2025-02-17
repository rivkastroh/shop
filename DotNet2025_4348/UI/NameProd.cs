namespace UI
{
    public partial class NameProd : Form
    {
        private BIApi.IBI _bi = BIApi.Factory.Get();
        private List<BO.ProductOrder> _productOrders;

        public NameProd(List<BO.ProductOrder> productOrders)
        {
            _productOrders = productOrders;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
