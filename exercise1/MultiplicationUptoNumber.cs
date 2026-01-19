using System;

namespace exercise1;

public class MultiplicationUptoNumber
{
    public static void Multiplication()
    {
        System.Console.Write("Input n: ");
        int n=Int32.Parse(Console.ReadLine());
        System.Console.Write("Input upto: ");
        int upto=Int32.Parse(Console.ReadLine());
        int[] row=new int[upto];
        for(int i=1;i<=upto;i++)
        {
            row[i-1]=n*i;
        }
       System.Console.WriteLine(string.Join(",",row));
    }
}
