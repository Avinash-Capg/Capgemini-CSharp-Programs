using System;

namespace exercise1;

public class ProfitOrLoss
{
    public static void ProfitOrLossCalculate()
    {
        System.Console.Write("Enter cost price: ");
        double costPrice=double.Parse(Console.ReadLine());
        if (costPrice == 0)
        {
            Console.WriteLine("Cost price cannot be zero");
            return;
        }
        System.Console.Write("Enter selling price: ");
        double sellingPrice=double.Parse(Console.ReadLine());
        double result=0;
       
        if(costPrice>sellingPrice)
        {
            double loss=costPrice-sellingPrice;
            result=(loss/costPrice)*100;
            System.Console.Write($"Loss : {result:F2}%");
        }
        else  if(sellingPrice>costPrice)
        {
            double profit=sellingPrice-costPrice;
            result=(profit/costPrice)*100;
            System.Console.Write($"Profit : {result:F2}%");
        }
        else
        {
            System.Console.Write("No profit/loss");
        }
    }
}
