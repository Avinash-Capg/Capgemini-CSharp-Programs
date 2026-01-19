using System;

namespace exercise1;

public class SecondConverter
{
    public static void SecondCalculate()
    {
        System.Console.Write("Input: ");
        int totalSeconds=Int32.Parse(Console.ReadLine());
        string formatted="";
        int minutes=totalSeconds/60;
        int seconds=totalSeconds%60;
        formatted=minutes+":"+seconds.ToString("D2");
        System.Console.WriteLine($"Output: {formatted}");
    }
}
