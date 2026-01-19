// See https://aka.ms/new-console-template for more information
using System;
using InterfaceDemoProj;

Console.WriteLine("Demo on Interfaces");

// IAdd m1 = new MathClass();       // only Add
// IAddSub m2 = new MathClass();    // Add + Sub
// IAll m3 = new MathClass();       // Add + Sub + Prod + Div

//Approach1
Product pObj=new Product();
pObj.ProdID=101;
pObj.Name="Borosil Flask";
pObj.Price=850;




//Approach2
//Object initializer
Product pObj1=new Product(){ProdID=102,Name="Luxor Marker",Price=25};



//Approach3 
//Collection Initializer
List<Product> prodList=new List<Product>()
{   
    new Product(){ProdID=101,Name="Sebamed Body Lotion",Price=1750},
    new Product(){ProdID=102,Name="Bellavita Perfume",Price=860},
    new Product(){ProdID=103,Name="Hotwheel Toy",Price=400},
    new Product(){ProdID=104,Name="Disney Bowl",Price=250},
    new Product(){ProdID=105,Name="Axcer 90mg",Price=2450},
    new Product(){ProdID=106,Name="Classmae 100Pg",Price=65},
    
};

foreach(var item in prodList)
{
    System.Console.WriteLine($"{item.ProdID}\t{item.Name}\t{item.Price}\t");
}