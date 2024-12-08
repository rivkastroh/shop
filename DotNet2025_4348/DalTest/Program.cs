using DO;
using DalApi;
using DalTest;
using Dal;
using DalList;
using System.Data.Common;
using Tools;
using System.Reflection;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{

    private static void ConsoleNav()
    {
        Console.WriteLine("choose:\nto method CRUD write 0\nto write log write 1\nto exit write 2");
        int choose = int.Parse(Console.ReadLine());
        Console.WriteLine(choose);
        if (choose == 0)
        {
            ChooseObjAndMethod();
        }
        else if (choose == 1)
        {
                WriteLog();
        }
    }
    private static void ChooseObjAndMethod()
    {
        bool flag = false;
        string obj;
        do
        {
            flag = false;
            Console.WriteLine("choose obj: product/sale/customer");
            obj = Console.ReadLine();
            if (obj != "customer" && obj != "sale" && obj != "product")
                flag = true;
        }
        while (flag);
        do
        {
            flag = false;
            Console.WriteLine("choose method: create/read/readAll/update/delete");
            string method = Console.ReadLine();
            switch (method)
            {
                case "create": Create(obj);
                    break;
                case "read": Read(obj);
                    break;
                case "readAll": ReadAll(obj);
                    break;
                case "update": UpDate(obj);
                    break;
                case "delete": Delete(obj);
                    break;
                default:
                    flag = true;
                    break;
            }
        }
        while (flag); 
    }
    private static void Create(string obj)
    {
        switch (obj)
        {
            case "product": CreateProduct();
                break;
            case "sale": CreateSale();
                break;
            case "customer": CreateCustomer();
                break;
        }
    }
    private static void CreateProduct()
    {
        Console.WriteLine("enter detals:\nbarcode:");
        int barcode = int.Parse(Console.ReadLine());
        Console.WriteLine("name:");
        string name= Console.ReadLine();
        int category= int.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        int quantityInStock = int.Parse(Console.ReadLine());
        try
        {
            Product product = new Product(barcode, name, (Categorys)category, price, quantityInStock);
            s_dal.Product.Create(product);
        }
        catch(Exception ex)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"eror: {ex.ToString()}");
            Console.WriteLine(ex.ToString());
        }
    }
    private static void CreateSale()
    {
        Console.WriteLine("enter detals:\n id:");
        int id = int.Parse(Console.ReadLine());
        Console.WriteLine("barcode:");
        int barcode = int.Parse(Console.ReadLine());
        Console.WriteLine("amountGetSale:");
        int amountGetSale= int.Parse(Console.ReadLine());
        Console.WriteLine("totalPrice:");
        double totalPrice = double.Parse(Console.ReadLine());
        Console.WriteLine("intendedAllCustomers:");
        bool intendedAllCustomers = bool.Parse(Console.ReadLine());
        Console.WriteLine("startSale:");
        DateTime startSale= DateTime.Parse(Console.ReadLine());
        Console.WriteLine("finishSale");
        DateTime finishSale = DateTime.Parse(Console.ReadLine());
        Sale s = new Sale(id, barcode, amountGetSale, totalPrice, intendedAllCustomers,startSale,finishSale);
        s_dal.Sale.Create(s);
    }
    private static void CreateCustomer()
    {
        Console.WriteLine("enter detalse:\n identity:");
        int identity = int.Parse(Console.ReadLine());
        Console.WriteLine("name:");
        string name = Console.ReadLine();
        Console.WriteLine("address:");
        string address = Console.ReadLine();
        Console.WriteLine("phone:");
        string phoneNumber = Console.ReadLine();
        s_dal.Customer.Create(new Customer(identity,name,address,phoneNumber));
    }



    private static void UpDate(string obj)
    {
        //מה הרעיון? זה ממש כמו כראיט
        switch (obj)
        {
            case "product":
                break;
            case "sale":
                break;
            case "customer":
                break;
        }
    }
    private static void Read(string obj)
    {
        Console.WriteLine("enter id:");
        int id = int.Parse(Console.ReadLine());
        switch (obj)
        {
            case "product": Console.WriteLine(s_dal.Product.Read(id));
                break;
            case "sale": Console.WriteLine(s_dal.Sale.Read(id));
                break;
            case "customer":Console.WriteLine(s_dal.Customer.Read(id));
                break;
        }
    }
    private static void ReadAll(string obj)
    {
        switch (obj)
        {
            case "product":
                Console.WriteLine(s_dal.Product.ReadAll());
                break;
            case "sale":
                Console.WriteLine(s_dal.Sale.ReadAll());
                break;
            case "customer":
                Console.WriteLine(s_dal.Customer.ReadAll());
                break;
        }
    }
    private static void Delete(string obj)
    {
        Console.WriteLine("enter id:");
        int id = int.Parse(Console.ReadLine());
        switch (obj)
        {
            case "product": 
                s_dal.Product.Delete(id);
                break;
            case "sale":
                s_dal.Sale.Delete(id);
                break;
            case "customer":
                s_dal.Customer.Delete(id);
                break;
        }
    }
    private static void WriteLog()
    {
        Console.WriteLine("enter text to log");
        string text = Console.ReadLine();
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, text);
    }

    private static readonly IDal s_dal;// = new DalList();
    //DataSource d = new DataSource();

    static void Main(string[] args)
    {
        try
        {
            //Initialization.Initialize(s_dal);
            ConsoleNav();
        }
        catch (Exception ex)
        {
            MethodBase  m = MethodBase.GetCurrentMethod();
            LogManager.WriteLog(m.DeclaringType.FullName,m.Name,$"eror: {ex.ToString()}");
            Console.WriteLine(ex.ToString());
        }
    }
}





