
using DO;

namespace Dal;

internal static class DataSource
{
    static internal List<Customer> _customers { get; set; } = new List<Customer>
    {
        new Customer(678901234, "רחל שמואלי", "רחוב חרוב 6", "050-6789012"),
        new Customer(123456789, "יוסי לוי", "רחוב פטל 1", "050-1111111"),
        new Customer(234567890, "מיה כהן", "רחוב שקד 2", "050-2222222"),
        new Customer(345678901, "דוד ישראלי", "רחוב תמר 3", "050-3333333"),
        new Customer(456789012, "שרה פז", "רחוב זית 4", "050-4444444"),
        new Customer(567890123, "אבי רוזן", "רחוב דקל 5", "050-5555555"),
        new Customer(678901345, "רונית שמואלי", "רחוב אלון 6", "050-6666666"),
        new Customer(789012456, "אלי ברק", "רחוב אורן 7", "050-7777777"),
        new Customer(890123567, "תמר נעים", "רחוב חרוב 8", "050-8888888"),
        new Customer(901234678, "משה בן דוד", "רחוב דובדבן 9", "050-9999999"),
        new Customer(123456780, "חנה גולדשטיין", "רחוב אפרסק 10", "050-1010101"),
        new Customer(234567891, "עדי שטרן", "רחוב רימון 11", "050-1212121"),
        new Customer(345678902, "גיא עוז", "רחוב ברוש 12", "050-1313131"),
        new Customer(456789013, "נועה בן חיים", "רחוב דקל 13", "050-1414141"),
        new Customer(567890124, "יואב מזרחי", "רחוב תמר 14", "050-1515151"),
        new Customer(678901235, "דנה סלע", "רחוב פטל 15", "050-1616161"),
        new Customer(789012346, "אורן לוי", "רחוב שקד 16", "050-1717171"),
        new Customer(890123457, "רוני כהן", "רחוב זית 17", "050-1818181"),
        new Customer(901234568, "ליה שקד", "רחוב אורן 18", "050-1919191"),
        new Customer(123456791, "טל עוז", "רחוב חרוב 19", "050-2020202"),
        new Customer(234567892, "אורי ברק", "רחוב דובדבן 20", "050-2121212"),
        new Customer(345678903, "אורית דיין", "רחוב גפן 21", "050-2222223"),
        new Customer(456789014, "שי רפאלי", "רחוב סיגל 22", "050-2323232"),
        new Customer(567890125, "נטלי עיני", "רחוב דקל 23", "050-2424242"),
        new Customer(678901236, "רן וולף", "רחוב חצב 24", "050-2525252"),
        new Customer(789012347, "דניאל ברוש", "רחוב נרקיס 25", "050-2626262"),
        new Customer(890123458, "מאיה לב", "רחוב שקד 26", "050-2727272"),
        new Customer(901234579, "עומרי טל", "רחוב תמר 27", "050-2828282"),
        new Customer(123456792, "אביגיל שוקרון", "רחוב דובדבן 28", "050-2929292"),
        new Customer(234567893, "רז חכם", "רחוב פטל 29", "050-3030303"),
        new Customer(345678904, "שקד נבון", "רחוב רימון 30", "050-3131313"),
        new Customer(456789015, "עידו לוי", "רחוב זית 31", "050-3232323"),
        new Customer(567890126, "ליאון רז", "רחוב אלון 32", "050-3333333"),
        new Customer(678901237, "אורלי שטרן", "רחוב חרוב 33", "050-3434343"),
        new Customer(789012348, "עידן גולן", "רחוב שקד 34", "050-3535353"),
        new Customer(890123459, "רוני גולן", "רחוב נרקיס 35", "050-3636363"),
        new Customer(901234580, "סיון פז", "רחוב דקל 36", "050-3737373"),
        new Customer(123456793, "אורי בן חיים", "רחוב ברוש 37", "050-3838383"),
        new Customer(234567894, "מאיה יוסף", "רחוב תמר 38", "050-3939393"),
        new Customer(345678905, "תמיר עוז", "רחוב דובדבן 39", "050-4040404"),
        new Customer(456789016, "ליה מזרחי", "רחוב אפרסק 40", "050-4141414"),
        new Customer(567890127, "טליה גולד", "רחוב חצב 41", "050-4242424"),
        new Customer(678901238, "אורי ברק", "רחוב זית 42", "050-4343434"),
        new Customer(789012349, "עדי שקד", "רחוב אורן 43", "050-4444444"),
        new Customer(890123460, "דודו טל", "רחוב פטל 44", "050-4545454"),
        new Customer(901234581, "אורן שמואלי", "רחוב שקד 45", "050-4646464")
    };
    static internal List<Product> _products { get; set; } = new List<Product>
    {
        new Product(150429, "מה שבטוח אני לא מחליטה- מה שבטוח הורדתי שליטה", Categorys.emona, 19.99, 100),
        new Product(654321, "קושי=מחמאה- העלתי אותך הקבצה", Categorys.emona, 29.99, 200),
        new Product(345678, "ד' מצייר את הציור ואת בוחרת באיזה צבעים לצבוע אותו", Categorys.emona, 39.99, 150),
        new Product(456789, "הוי מתפלל וחוזר ומתפלל ויש שעה שנותנים לך", Categorys.tfila, 49.99, 80),
        new Product(567890, "ואפילו אם יעברו כמה ימים ושנים אשר ידמו לו שלא הועילה תפילתו כלום, אל יניח מלהתפלל, סוף סוף יראה בעיניו שתפילתו הועילה לו מאוד(סטיפלר)", Categorys.tfila, 59.99, 60),
        new Product(678901, "כשתהיה עומד להתפלל יהא לבך שמח עליך שאתה מתפלל לאלוקים שאין כיוצא בו (מס\"י)", Categorys.tfila, 69.99, 40),
        new Product(789012, "הוא אמר: \"שלום!\"", Categorys.emona, 79.99, 20),
        new Product(123456, "הקב\"ה עומד לידך ומשתוקק לשמוע אותך", Categorys.tfila, 99.99, 100),
        new Product(234567, "אלוקי... אם תשרפני באש לא הוסיף כי אם אהבה ושמחה בך (חובת הלבבות)", Categorys.havatHashem, 49.99, 50),
        new Product(345678, "\"אהבת עולם אהבתיך על כן משכתיך חסד\" (ירמיה)", Categorys.havatHashem, 199.99, 30),
        new Product(456789, "\"אהבתי אתכם אמר ד'\" (מלאכי)", Categorys.havatHashem, 79.99, 20),
        new Product(567890, "\"תמים תהיה עם ד' אלוקיך\" (דברים)", Categorys.emona, 29.99, 70),
        new Product(678901, "\"ד' רעי לא אחסר\" (תהילים)", Categorys.emona, 59.99, 80),
        new Product(789012, "\"חרדת אדם יתן מוקש ובוטח בד' יסוגב\"- יסוגב מן הצרה (רבינו יונה)", Categorys.havatHashem, 299.99, 10),
        new Product(890123, "התפקיד שלנו הוא להפוך כל קושי- לאתגר", Categorys.nisayon, 15.99, 150),
        new Product(901234, "סומכים עליך מהשמים שתקחי אחריות", Categorys.nisayon, 149.99, 90),
        new Product(123457, "התגברות = התעלות", Categorys.nisayon, 99.99, 100),
        new Product(234568, "כל יהודי בכל מצב ורמה הוא יהלום יקר המאיר בכל העולמות", Categorys.havatYisrahel, 49.99, 50),
        new Product(345679, "לכל יהודי יש נקודה טובה ומעלה מיוחדת", Categorys.havatYisrahel, 199.99, 30),
        new Product(456780, "להבין ביהלומים", Categorys.havatYisrahel, 79.99, 20),
        new Product(567891, "מוצר 14", Categorys.havatHashem, 29.99, 70),
        new Product(678902, "מוצר 15", Categorys.havatHashem, 59.99, 80),
        new Product(789013, "מוצר 16", Categorys.havatHashem, 299.99, 10),
        new Product(890234, "מוצר 17", Categorys.havatHashem, 15.99, 150),
        new Product(901345, "מוצר 18", Categorys.havatHashem, 149.99, 90),
        new Product(123458, "מוצר 19", Categorys.havatHashem, 99.99, 100),
        new Product(234569, "מוצר 20", Categorys.havatHashem, 49.99, 50),
        new Product(345680, "מוצר 21", Categorys.havatHashem, 199.99, 30),
        new Product(456781, "מוצר 22", Categorys.havatHashem, 79.99, 20),
        new Product(567892, "מוצר 23", Categorys.havatHashem, 29.99, 70),
        new Product(678903, "מוצר 24", Categorys.havatHashem, 59.99, 80),
        new Product(789014, "מוצר 25", Categorys.havatHashem, 299.99, 10)
    };
    static internal List<Sale> _sales { get; set; } = new List<Sale>
    {
        new Sale(26, 123456, 10, 99.99, true, DateTime.Now, DateTime.Now.AddDays(7)),
        new Sale(0, 654321, 5, 49.99, false, DateTime.Now, DateTime.Now.AddDays(14)),
        new Sale(1, 123456, 10, 99.99, true, DateTime.Now, DateTime.Now.AddDays(7)),
        new Sale(2, 234567, 5, 49.99, false, DateTime.Now, DateTime.Now.AddDays(14)),
        new Sale(3, 345678, 20, 199.99, true, DateTime.Now, DateTime.Now.AddDays(10)),
        new Sale(4, 456789, 15, 79.99, true, DateTime.Now, DateTime.Now.AddDays(3)),
        new Sale(5, 567890, 8, 29.99, false, DateTime.Now, DateTime.Now.AddDays(5)),
        new Sale(6, 678901, 12, 59.99, true, DateTime.Now, DateTime.Now.AddDays(8)),
        new Sale(7, 789012, 30, 299.99, true, DateTime.Now, DateTime.Now.AddDays(20)),
        new Sale(8, 890123, 6, 15.99, false, DateTime.Now, DateTime.Now.AddDays(6)),
        new Sale(9, 901234, 25, 149.99, true, DateTime.Now, DateTime.Now.AddDays(12)),
        new Sale(10, 123457, 10, 99.99, true, DateTime.Now, DateTime.Now.AddDays(7)),
        new Sale(11, 234568, 5, 49.99, false, DateTime.Now, DateTime.Now.AddDays(14)),
        new Sale(12, 345679, 20, 199.99, true, DateTime.Now, DateTime.Now.AddDays(10)),
        new Sale(13, 456780, 15, 79.99, true, DateTime.Now, DateTime.Now.AddDays(3)),
        new Sale(14, 567891, 8, 29.99, false, DateTime.Now, DateTime.Now.AddDays(5)),
        new Sale(15, 678902, 12, 59.99, true, DateTime.Now, DateTime.Now.AddDays(8)),
        new Sale(16, 789013, 30, 299.99, true, DateTime.Now, DateTime.Now.AddDays(20)),
        new Sale(17, 890234, 6, 15.99, false, DateTime.Now, DateTime.Now.AddDays(6)),
        new Sale(18, 901345, 25, 149.99, true, DateTime.Now, DateTime.Now.AddDays(12)),
        new Sale(19, 123458, 10, 99.99, true, DateTime.Now, DateTime.Now.AddDays(7)),
        new Sale(20, 234569, 5, 49.99, false, DateTime.Now, DateTime.Now.AddDays(14)),
        new Sale(21, 345680, 20, 199.99, true, DateTime.Now, DateTime.Now.AddDays(10)),
        new Sale(22, 456781, 15, 79.99, true, DateTime.Now, DateTime.Now.AddDays(3)),
        new Sale(23, 567892, 8, 29.99, false, DateTime.Now, DateTime.Now.AddDays(5)),
        new Sale(24, 678903, 12, 59.99, true, DateTime.Now, DateTime.Now.AddDays(8)),
        new Sale(25, 789014, 30, 299.99, true, DateTime.Now, DateTime.Now.AddDays(20))
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
