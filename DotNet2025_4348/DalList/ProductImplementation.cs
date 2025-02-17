
namespace Dal;
using DO;
using DalApi;
using System;
using System.Reflection;
using Tools;

internal class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        Product p = DataSource._products.FirstOrDefault(p => p.Barcode==item.Barcode);
        if (p != null)
            throw new DalEntityAlreadyExistedException("ברקוד המוצר כבר קיים");
        DataSource._products.Add(item);
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"create prouct: {item}");
        return item.Barcode;
    }

    public void Delete(int id)
    {
        Product productFound = Read(id);
        if (productFound != null)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"remove product whith id: {id}");
            DataSource._products.Remove(productFound);
        }
        else
            throw new DalIDNumberDoesnotExistException("לא נמצא מזהה מוצר");
    }

    public Product Read(int barcode)
    {
        Product product = DataSource._products.FirstOrDefault(x => x.Barcode == barcode);
        if (product == null)
            throw new DalIDNumberDoesnotExistException("לא נמצא מזהה מוצר");
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"read product whith barcode: {barcode}");
        return product;
    }

    public Product? Read(Func<Product, bool> filter)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"read product white filter");
        return DataSource._products.FirstOrDefault(p=> filter(p));
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"readAll product");
        if (filter == null)
            return DataSource._products;
        return DataSource._products.Where(x => filter(x)).ToList();
    }

    public void Update(Product item)
    {
        this.Delete(item.Barcode);
        this.Create(item);
    }
}
