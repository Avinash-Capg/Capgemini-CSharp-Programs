
using System;

namespace Assignment4;
public class Program
{
    
    public static void Main()
    {
        Cake cObj=new Cake();
        System.Console.Write("Flavour options available\nVanilla\nChocolate\nRed Velvet\nEnter the flavour: ");
        cObj.Flavour=Console.ReadLine();
        
        System.Console.Write("Enter the quantity in kg: ");
        cObj.QuantityInKg=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter the price per kg: ");
        cObj.PricePerKg=Int32.Parse(Console.ReadLine());
        try
        {
            cObj.CakeOrder();
            System.Console.WriteLine("Cake order was successful");
            double discount=cObj.CalculatePrice();
            System.Console.WriteLine($"Price after discount is {discount}");
        
            
        }
        catch(InvalidFlavourException emessage)
        {
            System.Console.WriteLine(emessage.Message);
        }
        catch(InvalidQuantityException emessage)
        {
            System.Console.WriteLine(emessage.Message);
        }



    }
}
