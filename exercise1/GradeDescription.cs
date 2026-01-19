using System;

namespace exercise1;

public class GradeDescription
{
    public static void GradeCalculate()
    {
        
        Console.Write("Enter the grade of the student: ");
        char grade=char.Parse(Console.ReadLine());
        switch(grade)
        {
            case ('E'): Console.Write("Excellent");break;
            case ('V'):Console.Write("Very Good");break;
            case ('G'):Console.Write("Good");break;
            case ('A'):Console.Write("Average");break;
            case ('F'):Console.Write("Fail");break;
            default : Console.Write("Write a valid grade");break;
            
            
        }
    }

}
