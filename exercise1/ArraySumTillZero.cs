using System;

namespace exercise1;

public class ArraySumTillZero
{
    public static void SumCalculate()
    {
        System.Console.Write("Input: ");
        string input=Console.ReadLine();
        int sum=0;
        string[] arr=input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
        int[] nums=Array.ConvertAll(arr,int.Parse);
        foreach(var num in nums)
        {
           if(num==0)
            {
                break;
            }
            else if(num<0)
            {
                continue;
            }
            else
            {
                sum=sum+num;
            }
        }
        System.Console.WriteLine($"Output: {sum}");
    }
}
