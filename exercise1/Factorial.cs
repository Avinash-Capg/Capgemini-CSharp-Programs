//Factorial (Large numbers): Calculate N! and handle potential overflow for larger integers.
using System;

namespace exercise1;

public class Factorial
{
    public static void FactorialCalculate()
    {
        System.Console.Write("Enter a number to calculate the factorial: ");
        int number=Int32.Parse(Console.ReadLine());
        long result=Fact(number);
        System.Console.WriteLine(result);
       
    }
    public static long Fact(int n)
    {
        int i=1;
        long factResult=1;
        while(i<=n)
        {
            factResult=factResult*i;
            i++;
            
        }

        
        return factResult;
    }
}
