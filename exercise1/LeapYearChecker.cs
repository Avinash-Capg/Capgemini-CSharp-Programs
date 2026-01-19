using System;

namespace exercise1;

public class LeapYearChecker
{
    public static void LeapYearCalculate()
    {
        Console.Write("Enter the year: ");
        int year=Int32.Parse(Console.ReadLine());
        if((year%400==0 )||(year%4==0 && year%100!=0))
        {
            Console.WriteLine("Year {0} is a leap year",year);
        }else
        {
            Console.WriteLine("Year {0} is not a leap year",year);
        }
    }

}
