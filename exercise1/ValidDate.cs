//Valid Date Check: Input day/month/year and check if it's a valid calendar date (handle Feb 29).
using System;

namespace exercise1;

public class ValidDate
{
    public static void ValidDateCheck()
    {
        System.Console.Write("Enter day: ");
        int day=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter month: ");
        int month=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter year: ");
        int year=Int32.Parse(Console.ReadLine());
        
        int maxDays=0;
        if(month>=1 && month<=12)
        {
            if(month==1||month==3||month==5||month==7||month==8||month==10||month==12)
            {
                
                maxDays=31;
            }
            else if(month==4||month==6||month==9||month==11)
            {
                maxDays=30;
            }
            else if(month==2)
            {
                bool isLeap=(year%400==0) || ((year%4==0) && (year%100!=0));
                if(isLeap)
                {
                    maxDays=29;
                }
                else
                {
                    maxDays=28;
                }
               
            }
            if(day>=1 && day<=maxDays)
            {
                System.Console.WriteLine("Valid Date");
            }
            else
            {
                System.Console.WriteLine("Invalid Date");
            }
        }
        else
        {
            System.Console.WriteLine("Invalid Date");
        }


    }
}
