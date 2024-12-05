﻿using DO;
using DalApi;

namespace DalTest;

public static class Initialization
{
    private static IDal? s_dal;

    private static void createCustomer()
    {
        s_dal.Customer.Create(new Customer());
    }
    private static void createProduct()
    {
        s_dal.Product.Create(new Product());
    }
    private static void createSale()
    {
        s_dal.Sale.Create(new Sale());
    }
    public static void Initialize(IDal dal)
    {
        s_dal = dal;
        createCustomer();
        createProduct();
        createSale();
    }
}
