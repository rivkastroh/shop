using DO;
using DalApi;
using DalTest;
using Dal;
using DalList;
using System.Data.Common;
using Tools;
using System.Reflection;

public class Program
{

    private static int consoleNav()
    {
        return 0;
    }
    private static void chooseObj()
    {
        Console.WriteLine("choose obj: product/sale/customer");
        string obj = Console.ReadLine();
        switch (obj)
        {
            case "product":
                break;
            case "sale":
                break;
            case "customer":
                break;
            default: Console.WriteLine("eror");
                break;
        }
    }
    private static void chooseMethod()
    {
        Console.WriteLine("choose method: create/read/readAll/update/delete");
        string method = Console.ReadLine();
        switch (method)
        {
            case "create":
                break;
            case "read":
                break;
            case "readAll":
                break;
            case "update":
                break;
            case "delete":
                break;
            default: Console.WriteLine("eror");
                break;
        }
    }

    //private static readonly IDal s_dal = new DalList();
    //DataSource d = new DataSource();

    static void Main(string[] args)
    {
        try
        {
            //Initialization.Initialize(s_dal);
            Console.WriteLine(Directory.GetCurrentDirectory());
            Console.WriteLine($"time: {DateTime.Now:yyyyMM}");
        }
        catch (Exception ex)
        {
            MethodBase  m = MethodBase.GetCurrentMethod();
            LogManager.WriteLog(m.DeclaringType.FullName,m.Name,$"eror: {ex.ToString()}");
            Console.WriteLine(ex.ToString());
        }
    }
}





