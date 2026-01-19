//Fibonacci Series: Display the first N terms of the Fibonacci sequence.
using System;

namespace exercise1;

public class Fibonacci
{
    public static void FibonacciCalculate()
    {
        System.Console.Write("Enter the input for fibonacci sequence: ");
        int fibNum=Int32.Parse(Console.ReadLine());
        int first=0;
        int second=1;
        int count=0;
        while(count<fibNum)
        {
            System.Console.WriteLine(first);
            int temp=first;
            first=first+second;
            second=temp;
            count++;

        }


    }
}
