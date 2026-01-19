using System;

namespace exercise1;

public class AdmissionChecker
{
    public static void AdmissionCheck()
    {
        
        Console.Write("Enter marks of Maths: ");
        int maths=Int32.Parse(Console.ReadLine());
        Console.Write("Enter marks of Physics: ");
        int physics=Int32.Parse(Console.ReadLine());
        Console.Write("Enter marks of Chemistry: ");
        int chemistry=Int32.Parse(Console.ReadLine());
        int totalMarks=maths+physics+chemistry;
        if(((maths>=65)&&(physics>=55)&&(chemistry>=50))&&((totalMarks>=180)||(maths+physics>=140)))
        {
            Console.WriteLine("Student is eligible for admission");
        }
        else
        {
            Console.WriteLine("Student is not eligible for admission");
        }
    }
}
