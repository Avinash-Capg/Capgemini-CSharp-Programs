using System;
using System.Collections.Generic;
using System.Text;

namespace CustomPropertyDemo
{
    class PrimeCustomer:Customer
    {
        public List<Orders> MyPrimeOrders//Write Only Property
        { 
            set
            {
                MyOrders = value;
            }
                
        }

    }
}
