
using DO;

namespace Dal;

static internal class DataSource
{
    static internal List<Customer> _customers { get; set; } = new List<Customer>();
    static internal List<Product> _products { get; set; } = new List<Product>();
    static internal List<Sale> _sales { get; set; } = new List<Sale>();


    //איפה משתמשים בזה?
    static internal class Config{
        internal const int _baseBarcode = 1111;
        private static int _privateConfigBarcode =_baseBarcode;
        public static int ConfigBarcode
        {
            get
            {
                return _privateConfigBarcode++;
            }
        }

        internal const int _baseProduct = 1111;
        private static int _privateConfigProduct = _baseProduct;
        public static int ConfigProduct
        {
            get
            {
                return _privateConfigProduct++;
            }
        }

        internal const int _baseSale = 1111;
        private static int _privateConfigSale = _baseSale;
        public static int ConfigSale
        {
            get
            {
                return _privateConfigSale++;
            }
        }
    }
}
