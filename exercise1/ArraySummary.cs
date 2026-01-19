using System;

namespace exercise1;

public class ArraySummary
{
    public static void Summary()
    {
        System.Console.Write("Input: ");
        string input=Console.ReadLine();
        string[] parts=input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        int[] arr=Array.ConvertAll(parts,int.Parse);
        int minArray=arr[0];
        int maxArray=arr[0];
        int sumArray=0;
        double avgOfArray;
        for(int i=0;i<arr.Length;i++)
        {
            sumArray=sumArray+arr[i];
            if(arr[i]<minArray)
            {
                minArray=arr[i];
            }
            if(arr[i]>maxArray)
            {
                maxArray=arr[i];
            }
        }
        avgOfArray=sumArray/arr.Length;
        string output="min="+minArray+", max="+maxArray+", sum="+sumArray+", avg="+avgOfArray.ToString("F2");
        System.Console.WriteLine($"Output: {output}");
    }
}
