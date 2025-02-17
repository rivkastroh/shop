
namespace Dal;
using DO;
using DalApi;
using System;
using Tools;
using System.Reflection;

internal class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        Customer c = DataSource._customers.FirstOrDefault(c => item.Identity==c.Identity);
        if (c != null) {
            throw new DalEntityAlreadyExistedException("תז משתמש זה כבר קיים");
        }
        DataSource._customers.Add(item);
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"create customer: {item}");
        return item.Identity;
    }

    public void Delete(int identity)
    {
        Customer saleFound = Read(identity);
        if (saleFound != null)
        {
            DataSource._customers.Remove(saleFound);
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"remove customer whith identity: {identity}");
        }
        else
            throw new DalIDNumberDoesnotExistException("התז לא קימת");
    }

    public Customer Read(int identity)
    {
        Customer customer = DataSource._customers.FirstOrDefault(c => c.Identity== identity);
        if (customer == null)
        {
            throw new DalIDNumberDoesnotExistException("התז לא קימת");
        }
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"read customer whith identity: {identity}");
        return customer;
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"read filter customer");
        return DataSource._customers.FirstOrDefault(c => filter(c));
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"readAll customer");
        if (filter == null)
          return DataSource._customers;
        return DataSource._customers.Where(c => filter(c)).ToList();
    }

    public void Update(Customer item)
    {
        this.Delete(item.Identity);
        this.Create(item);
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteLog(m.DeclaringType.FullName, m.Name, $"update customer: {item}");
    }
}
