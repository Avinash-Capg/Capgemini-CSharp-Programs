using System;

namespace exercise1;

public class AreaOfCircle
{
    public static void AreaCalculate()
    {
        System.Console.Write("Input: ");
        double radius=double.Parse(Console.ReadLine());
        double area=Math.PI*radius*radius;
        System.Console.Write($"Output: {Math.Round(area,2,MidpointRounding.AwayFromZero)}");
        
    }
}
