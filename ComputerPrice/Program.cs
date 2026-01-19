// See https://aka.ms/new-console-template for more information
using System;

namespace AssessmentTask3;
class Program
{
    public static void Main()
    {
         Desktop dObj =new Desktop();
         Laptop lObj=new Laptop();
        System.Console.WriteLine("1.Desktop\n2.Laptop");
        System.Console.Write("Choose the option: ");

        int option=Int32.Parse(Console.ReadLine());
        
        if(option==1)
        {
            System.Console.Write("Enter the processor: ");
            dObj.Processor=Console.ReadLine();

            System.Console.Write("Enter the ram size: ");
            dObj.RamSize=Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter the hard disk size: ");
            dObj.HardDiskSize=Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter the graphic card size: ");
            dObj.GraphicCard=Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter the monitor size: ");
            dObj.MonitorSize=Int32.Parse(Console.ReadLine());


            System.Console.Write("Enter the power supply volt: ");
            dObj.PowerSupplyVolt=Int32.Parse(Console.ReadLine());
            
            System.Console.WriteLine($"Laptop price is: {dObj.DesktopPriceCalculation()}");
            


        }  
        else if(option==2)
        {
            System.Console.Write("Enter the processor: ");
            lObj.Processor=Console.ReadLine();

            System.Console.Write("Enter the ram size: ");
            lObj.RamSize=Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter the hard disk size: ");
            lObj.HardDiskSize=Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter the graphic card size: ");
            lObj.GraphicCard=Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter the display size: ");
            lObj.DisplaySize=Int32.Parse(Console.ReadLine());

            System.Console.Write("Enter the battery volt: ");
            lObj.BatteryVolt=Int32.Parse(Console.ReadLine());

            
            
            System.Console.WriteLine($"Laptop price is: {lObj.LaptopPriceCalculation()}");
        } 
        

    }
}