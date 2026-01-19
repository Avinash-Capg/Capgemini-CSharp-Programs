using System;
using System.Collections.Generic;
using System.Text;

namespace CustomPropertyDemo
{
     class Customer
     {
        List<Orders> orderList;//object of list
        public Customer()
        {
            orderList = new List<Orders>();
        }
        public int CustID { get; set; }
        public string Name { get; set; }
        public Address BillingAddr { get; set; }
        public Address ShippingAddr { get; set; }
        public List<Orders> MyOrders //property of List type
        { 
            get
            {
                return orderList;
            }
            protected set
            {
                orderList = value;
            }
        }
    }
    
}
