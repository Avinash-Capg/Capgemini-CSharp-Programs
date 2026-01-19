// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
namespace Assignment7;

class Program
{
    public static void Main()
    {
       
        CabDetails detailsObj=new CabDetails();
        System.Console.WriteLine("Enter the booking id");
        detailsObj.BookingID=Console.ReadLine();
        if(detailsObj.ValidateBookingID())
        {
            System.Console.WriteLine("Enter the cab type");
            detailsObj.CabType=Console.ReadLine();

            System.Console.WriteLine("Enter the distance in km");
            detailsObj.Distance=double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the waiting time in minutes");
            detailsObj.WaitingTime=Int32.Parse(Console.ReadLine());
        
            double price=detailsObj.CalculateFareAmount();
            Console.WriteLine($"The fare amount is {price:F2}");

        }
        else
        {
            Console.WriteLine("Invalid booking id");
        }

        
        
    }
}


