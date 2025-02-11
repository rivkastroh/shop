
using DO;

namespace Dal;

internal static class DataSource
{
    static internal List<Customer> _customers { get; set; } = new List<Customer>();
    static internal List<Product> _products { get; set; } = new List<Product>
    {
        new Product(123456, "מה שבטוח אני לא מחליטה- מה שבטוח הורדתי שליטה", Categorys.emona, 19.99, 100),
        new Product(654321, "קושי=מחמאה- העלתי אותך הקבצה", Categorys.emona, 29.99, 200),
        new Product(345678, "ד' מצייר את הציור ואת בוחרת באיזה צבעים לצבוע אותו", Categorys.emona, 39.99, 150),
        new Product(456789, "הוי מתפלל וחוזר ומתפלל ויש שעה שנותנים לך", Categorys.tfila, 49.99, 80),
        new Product(567890, "מוצר 5", Categorys.tfila, 59.99, 60),
        new Product(678901, "מוצר 6", Categorys.tfila, 69.99, 40),
        new Product(789012, "מוצר 7", Categorys.havatHashem, 79.99, 20)
    };
    static internal List<Sale> _sales { get; set; } = new List<Sale>
    {
    new Sale(1, 123456, 10, 99.99, true, DateTime.Now, DateTime.Now.AddDays(7)),
    new Sale(2, 654321, 5, 49.99, false, DateTime.Now, DateTime.Now.AddDays(14))
    };


    //איפה משתמשים בזה?
    static internal class Config
    {
        internal const int _baseBarcode = 1111;
        private static int _privateConfigBarcode = _baseBarcode;
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
