//Electricity Bill: Calculate bill: First 199 units @ 1.20; 200-400 @ 1.50; 400-600 @ 1.80; above 600 @ 2.00. Add 15% surcharge if bill > 400.
using System;

namespace exercise1;

public class ElectricityBill
{
    public static void BillCalculate()
    {
        System.Console.Write("Enter units: ");
        int units=Int32.Parse(Console.ReadLine());
        double billCharge=0;
        if(units<=199)
        {
            billCharge=units*1.20;
        }
        else if(units>=200 && units<=400)
        {
            billCharge=units*1.50;
        }
        else if(units>400 && units<=600)
        {
            billCharge=units*1.80;
        }
         else if(units>600)
        {
            billCharge=units*2.00;
        }
        if(units>400)
        {
            billCharge=billCharge+billCharge*0.15;
        }
        System.Console.WriteLine($"The final bill is: {billCharge}");
    }
}
