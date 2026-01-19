//Prime Number: Check if a number is prime using a for loop and break.
using System;

namespace exercise1;

public class PrimeNumber
{
    public static void PrimeNumberCalculate()
    {
        System.Console.Write("Enter the number to check if it is prime or not: ");
        int number=Int32.Parse(Console.ReadLine());
        bool isPrime=true;
        if(number==0 || number==1 || number<0)
        {
            System.Console.WriteLine("Neither prime nor composite");
        }
        else{
        
        int limit=(int)Math.Sqrt(number);
        for(int i=2;i<=limit;i++)
        {
            
            if(number%i==0)
            {
                isPrime=false;

                break;
            }
        }
        
        if(isPrime)
        {
            System.Console.WriteLine("Number is prime");
        }
        else
        {
             System.Console.WriteLine("Number is not prime");
        }
        }
    }
    }

