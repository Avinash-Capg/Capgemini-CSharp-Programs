// See https://aka.ms/new-console-template for more information
using System;
using Assignment5;

class Program
{
    
    public static void Main()
    {
        
        Candy candy=new Candy();
        System.Console.Write("Enter the flavour: ");
        candy.Flavour=Console.ReadLine();
        System.Console.Write("Enter the quantity: ");
        candy.Quantity=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter the price per piece: ");
        candy.PricePerPiece=Int32.Parse(Console.ReadLine());
        if(candy.ValidateCandyFlavour())
        {   
            Program program=new Program();
            candy=program.CalculatedDiscountedPrice(candy);
        
            System.Console.WriteLine($"Flavour: {candy.Flavour}");
            System.Console.WriteLine($"Quantity: {candy.Quantity}");
            System.Console.WriteLine($"Price Per Piece: {candy.PricePerPiece}");
            System.Console.WriteLine($"Total Price: {candy.Quantity*candy.PricePerPiece}");
            System.Console.WriteLine($"Discount Price: {candy.TotalPrice-(candy.TotalPrice*(candy.Discount/100))}");
            }

    }
  
    public Candy CalculatedDiscountedPrice(Candy candy)
    {
       if(candy.Flavour=="Strawberry")
        {
            candy.Discount=15;
        }
        else if(candy.Flavour=="Lemon")
        {
            candy.Discount=10;
        }
        else if(candy.Flavour=="Mint")
        {
            candy.Discount=5;
        }
       candy.TotalPrice=candy.Quantity*candy.PricePerPiece;
       double discountedPrice=candy.TotalPrice-(candy.TotalPrice*candy.Discount/100);
       return candy;

    }
}
