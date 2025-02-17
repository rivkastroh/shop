namespace Dal;
using DO;
using DalApi;
using System;
using System.Reflection;
using Tools;

internal class SaleImplemention : ISale
{
    public int Create(Sale item)
    {
        Sale s= DataSource._sales.FirstOrDefault(s => s.Id == item.Id);
        if (s != null)
          throw new DalEntityAlreadyExistedException("מזהה המבצע כבר קיים");
        DataSource._sales.Add(item);
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"create sale: {item}");
        return item.Id;
    }

    public void Delete(int id)
    {
        Sale saleFound = Read(id);
        if (saleFound != null)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"delete sale with id: {id}");
            DataSource._sales.Remove(saleFound);
        }
        else
            throw new DalIDNumberDoesnotExistException("לא נמצא מזהה מבצע");
    }

    public Sale Read(int id)
    {
        Sale s = DataSource._sales.FirstOrDefault(s=> s.Id==id);
        if (s == null)
          throw new DalIDNumberDoesnotExistException("לא נמצא מזהה מבצע");
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"read sale with id: {id}");
        return s;
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"read filter sale");
        return DataSource._sales.FirstOrDefault(s=> filter(s));
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"readAll sale");
        if (filter == null)
            return DataSource._sales;
        return DataSource._sales.Where(s => filter(s)).ToList();
    }

    public void Update(Sale item)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"update sale: {item}");
        this.Delete(item.Id);
        this.Create(item);
    }
}
