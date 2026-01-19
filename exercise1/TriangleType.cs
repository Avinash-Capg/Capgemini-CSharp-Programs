using System;

namespace exercise1;

public class TriangleType
{
    public static void TriangleCheck()
    {
        System.Console.WriteLine("Enter the sides of the triangle");
        System.Console.Write("Enter first side: ");
        int side1=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter second side: ");
        int side2=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter third side: ");
        int side3=Int32.Parse(Console.ReadLine());
        if((side1==side2)&&(side2==side3)&&(side3==side1))
        {
            System.Console.WriteLine("Triangle is equilateral");
        }
        else if((side1==side2)||(side2==side3)||(side3==side1))
        {
            System.Console.WriteLine("Triangle is isosceles");
        }
        else
        {
            System.Console.WriteLine("Triangle is scalene");
        }

    }
}
