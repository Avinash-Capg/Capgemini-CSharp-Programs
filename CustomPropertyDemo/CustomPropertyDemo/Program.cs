using System;
using System.Collections.Generic;
namespace CustomPropertyDemo
{
    struct Customer1//Value types in C#
    {
        int id;
        string name;

        //public int ID { get; set; } = 0;
        //public  string Name{ get; set; }
        public Customer1(int id1, string nm)
        {
            id = id1;
            name = nm;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Customer Object first
            PrimeCustomer primeObj = new PrimeCustomer();
            primeObj.CustID = 101;
            primeObj.Name = "Alok";

            //Init the ShippingAddr
            primeObj.ShippingAddr = new Address();
            primeObj.ShippingAddr.FlatNo = 1802;
            primeObj.ShippingAddr.BuildingName = "Sky Tower";
            primeObj.ShippingAddr.Street = "Lane 1";
            primeObj.ShippingAddr.Locality="Wakad";
            primeObj.ShippingAddr.City = "Pune";

            //1 Customer can have many orders
            
            primeObj.MyPrimeOrders = new List<Orders>()
            {
                new Orders{OrderID=1124,OrderDate=new DateTime(2001,12,22),Amount=14000},
                new Orders{OrderID=2076,OrderDate=new DateTime(2002,3,12),Amount=24000},
                new Orders{OrderID=8540,OrderDate=new DateTime(2002,10,12),Amount=4000},
                new Orders{OrderID=1212,OrderDate=new DateTime(2008,1,26),Amount=2000},
            };
            Console.WriteLine($"Customer ID: {primeObj.CustID}");
            Console.WriteLine($"Customer Name: {primeObj.Name}");
            Console.WriteLine($"Customer FlatNo: {primeObj.ShippingAddr.FlatNo}");
            Console.WriteLine($"Customer BuildingName: {primeObj.ShippingAddr.BuildingName}");
            Console.WriteLine($"Customer Street: {primeObj.ShippingAddr.Street}");
            Console.WriteLine($"Customer Locality: {primeObj.ShippingAddr.Locality}");
            Console.WriteLine($"Customer City: {primeObj.ShippingAddr.City}\n");
            Console.WriteLine("Order Details");
            foreach (var item in primeObj.MyOrders)
            {
                Console.WriteLine($"OrderID: {item.OrderID} OrderDate: {item.OrderDate:dd-MM-yyyy} Amount: {item.Amount}");
            }

        }
    }
}