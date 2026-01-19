using System;

namespace exercise1{

public class LargestOfThree
{

    public static void LargestOfThreeCalculate()
    {
        System.Console.WriteLine("Enter three numbers for comparison");
        System.Console.Write("Enter number1: ");
        int num1=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter number2: ");
        int num2=Int32.Parse(Console.ReadLine());
        System.Console.Write("Enter number3: ");
        int num3=Int32.Parse(Console.ReadLine());
        if(num1>=num2 && num1>=num3)
        {
            System.Console.WriteLine("The largest number is {0}",num1);
        }
        else if(num2>=num1 && num2>=num3)
        {
            System.Console.WriteLine("The largest number is {0}",num2);
        }
        else
        {
            System.Console.WriteLine("The largest number is {0}",num3);
        }
    }
}
}