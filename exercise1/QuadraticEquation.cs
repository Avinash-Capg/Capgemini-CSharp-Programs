using System;

namespace exercise1;

public class QuadraticEquation
{
    public static void QuadraticSolution()
    {
        System.Console.Write("Enter coefficient a: ");
        int a=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter coefficient b: ");
        int b=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter coefficient c: ");
        int c=Int32.Parse(Console.ReadLine());
        int discriminant=b*b-(4*a*c);
        System.Console.WriteLine($"Discriminant:  {discriminant}");
        if(discriminant==0)
        {
            
            double soln=(double)(-b+Math.Sqrt(discriminant))/(2*a);
            System.Console.WriteLine($"One equal square root: {soln}");
        }
        else if(discriminant>0)
        {
            
            double soln1=(double)(-b+Math.Sqrt(discriminant))/(2*a);
            double soln2=(double)(-b-Math.Sqrt(discriminant))/(2*a);
            System.Console.WriteLine($"Two distinct real roots exits: {soln1} ,{soln2}");
            
        }
        else if(discriminant<0)
        {
            System.Console.WriteLine("No real roots exits");
        }

    }
   
}
