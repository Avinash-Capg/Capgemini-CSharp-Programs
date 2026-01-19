// Continue Usage: Print numbers from 1 to 50, but skip all multiples of 3 using continue.
using System;


namespace exercise1;

public class ContinueUsage
{
    public static void ContinueMethod()
    {
        System.Console.WriteLine("Printing numbers from 1 to 50 by skipping all multiples of three");
        for(int i=1;i<=50;i++)
        {
            if(i%3==0)
            {
                continue;
            }
            else
            {
                System.Console.WriteLine(i);
            }
        }
        
    }
}
