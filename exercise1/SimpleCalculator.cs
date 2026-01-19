using System;

namespace exercise1;

public class SimpleCalculator
{
    public static void Calculation()
    {
        
        Console.Write("Enter the user operator input: ");
        char input=char.Parse(Console.ReadLine());
        Console.Write("Enter the first input: ");
        int firstInput=Int32.Parse(Console.ReadLine());
        Console.Write("Enter the second input: ");
        int secondInput=Int32.Parse(Console.ReadLine());
        switch(input)
        {
            case ('+'): Console.Write("The addition of {0} and {1} is {2}",firstInput,secondInput,firstInput+secondInput);break;
            case ('-'):Console.Write("The subtraction of {0} and {1} is {2}",firstInput,secondInput,firstInput-secondInput);break;
            case ('*'):Console.Write("The multiplication of {0} and {1} is {2}",firstInput,secondInput,firstInput*secondInput);break;
            case ('/'):Console.Write("The division of {0} and {1} is {2}",firstInput,secondInput,firstInput/secondInput);break;
            default : Console.Write("Write a valid operator");break;
            
            
        }
    }

}
