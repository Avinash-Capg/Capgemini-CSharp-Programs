using System;
namespace exercise1;

public class HeightCategory
{
    public static void HeightCategoryCalculate()
    {
        System.Console.Write("Input: ");
        int heightCm=Int32.Parse(Console.ReadLine());
        string category="";
        if(heightCm>=0 && heightCm<150)
        {
            category="Short";
        }
        else if(heightCm>=150 && heightCm<180)
        {
            category="Average";
        }
        else if(heightCm>=180 && heightCm<=300)
        {
            category="Tall";
        }
        else
        {
            System.Console.WriteLine("Invalid Input");
        }
        System.Console.Write($"Output: {category}");
    }
}
