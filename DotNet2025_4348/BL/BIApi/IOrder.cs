﻿namespace BIApi
{
    public interface IOrder
    {
        public void addProduct(BO.Order order,BO.ProductOrder productOrder);
        public double orderTermination(BO.Order order);
        public BO.ProductOrder isExixt(BO.Order order,int barcode);
    }
}
