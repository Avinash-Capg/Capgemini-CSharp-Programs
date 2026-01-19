using System;

namespace exercise1;

public class QuadrantFinder
{
     public static void QuadrantCheck()
    {
        
        Console.Write("Enter the x coordinate: ");
        int x=Int32.Parse(Console.ReadLine());
        Console.Write("Enter the y coordinate: ");
        int y=Int32.Parse(Console.ReadLine());
        if(x>0 && y>0)
        {
            Console.WriteLine("The points lies in first quadrant");
        }
        else if(x<0 && y>0)
        {
            Console.WriteLine("The points lies in second quadrant");
        }
        else if(x<0 && y<0)
        {
            Console.WriteLine("The points lies in third quadrant");
        }
        else if(x>0 && y<0)
        {
            Console.WriteLine("The points lies in forth quadrant");
        }
        else
        {
            Console.WriteLine("The points lies in the origin");
        }
    }
}
