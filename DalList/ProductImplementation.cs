
namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;

internal class ProductImplementation : IProduct
{
    int IProduct.Create(Product item)
    {
        throw new NotImplementedException();
    }

    void IProduct.Delete(int id)
    {
        throw new NotImplementedException();
    }

    Product IProduct.Read(int id)
    {
        throw new NotImplementedException();
    }

    List<Product> IProduct.ReadAll()
    {
        throw new NotImplementedException();
    }

    void IProduct.Update(Product item)
    {
        throw new NotImplementedException();
    }
}
