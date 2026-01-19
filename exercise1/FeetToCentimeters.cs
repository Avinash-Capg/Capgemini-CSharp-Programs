using System;

namespace exercise1;

public class FeetToCentimeters
{
    public static void CentimeterCalculate()
    {
        System.Console.Write("Input: ");
        int feet=Int32.Parse(Console.ReadLine());
        double output=feet*30.48;
        System.Console.Write($"Output: {Math.Round(output,2,MidpointRounding.AwayFromZero)}");
    }
}
