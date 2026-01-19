// See https://aka.ms/new-console-template for more information
using System;
namespace exercise1;
class Program
{
    static void Main()
    {
        //Height Category: Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).
        //Height.HeightCalculate();

        //Largest of Three: Take three integers and find the maximum using nested if.
        //LargestOfThree.LargestOfThreeCalculate();

        //Leap Year Checker: Determine if a year is leap (Divisible by 400 OR (Divisible by 4 and NOT 100)).
        //LeapYearChecker.LeapYearCalculate();

        //Admission Eligibility: Math ≥ 65, Phys ≥ 55, Chem ≥ 50 AND (Total ≥ 180 OR Math+Phys ≥ 140).
        //AdmissionChecker.AdmissionCheck();

        //Grade Description: Input grade (E, V, G, A, F) and print (Excellent, Very Good, Good, Average, Fail) using switch.
        //GradeDescription.GradeCalculate();

        //Simple Calculator: Use switch to perform +, -, *, / based on user operator input.
        //SimpleCalculator.Calculation();

        //Vowel or Consonant: Use a switch statement to check if a character is a vowel.
        //VowelChecker.VowelCheck();

        //Quadrant Finder: Take (x,y) coordinates and print which quadrant they lie in.
        //QuadrantFinder.QuadrantCheck();

        //Triangle Type: Check if a triangle is Equilateral, Isosceles, or Scalene based on side lengths.
        //TriangleType.TriangleCheck();

        //Continue Usage: Print numbers from 1 to 50, but skip all multiples of 3 using continue.
        //ContinueUsage.ContinueMethod();

        //Factorial (Large numbers): Calculate N! and handle potential overflow for larger integers.
        //Factorial.FactorialCalculate();

        //Fibonacci Series: Display the first N terms of the Fibonacci sequence.
        //Fibonacci.FibonacciCalculate();

        //Prime Number: Check if a number is prime using a for loop and break.
        //PrimeNumber.PrimeNumberCalculate();

        //Quadratic Equation: Calculate roots of $ax^2 + bx + c = 0$ using if-else to check the discriminant.
        //QuadraticEquation.QuadraticSolution();

        //Electricity Bill: Calculate bill: First 199 units @ 1.20; 200-400 @ 1.50; 400-600 @ 1.80; above 600 @ 2.00. Add 15% surcharge if bill > 400.
        //ElectricityBill.BillCalculate();

        //Valid Date Check: Input day/month/year and check if it's a valid calendar date (handle Feb 29).
        //ValidDate.ValidDateCheck();

        //Write a method that returns the area of a circle for a given radius Round the result to 2 decimal places (MidpointRounding.AwayFromZero). Input: radius (double)
        // Output: area (double ) Constraints: 0 <= radius <= 1e6"
        //AreaOfCircle.AreaCalculate();


        // Write a method that converts feet to centimeters.Use: 1 foot = 30.48 cm Round the result to 2 decimal places (MidpointRounding.AwayFromZero).
        // Input: feet (int)  Output: centimeters (double)  Constraints:0 <= feet <= 1e6"
        //FeetToCentimeters.CentimeterCalculate();


        // Given a person's height in centimeters, return the height category:
        // - ""Short""  : height < 150
        // - ""Average"": 150 <= height < 180
        // - ""Tall""   : height >= 180
        // Input: heightCm (int) Output: category (string) Constraints 0 <= heightCm <= 300"
        //HeightCategory.HeightCategoryCalculate();


        // Q5. Convert a number of seconds into a string formatted as m:ss.Seconds must be 2 digits (leading zero if needed).
        // Input: totalSeconds (int) Output: formatted (string) Constraints: 0 <= totalSeconds <= 1e9"
        // Examples:
        // 125 -> ""2:05""
        // 60  -> ""1:00""
        //SecondConverter.SecondCalculate();


        // Q6. Given an integer array, sum only positive numbers until you reach 0.
        // - If an element is 0, stop processing (break).
        // - If an element is negative, ignore it (continue).
        // Input: nums (int[]) Output: sum (int) Constraints: 0 <= nums.Length <= 1e5, -1e9 <= nums[i] <= 1e9"
        //ArraySumTillZero.SumCalculate();


        // Q7. Return the multiplication table row for a number n from 1..upto. Example: n=3, upto=5 -> [3,6,9,12,15]
        // Input: n (int), upto (int)  Output: row (int[]) Constraints:0 <= upto <= 1e5  -1e4 <= n <= 1e4
        //MultiplicationUptoNumber.Multiplication();

        //Profit/Loss: Calculate profit or loss percentage based on Cost Price and Selling Price.
        //ProfitOrLoss.ProfitOrLossCalculate();  

        //Given an integer array, return a summary string:  min=<min>; max=<max>; sum=<sum>; avg=<avg>  Average must be rounded to 2 decimals (AwayFromZero).
        //Input: nums (int[]) Output: summary (string)  Constraints:  1 <= nums.Length <= 1e5      
        ArraySummary.Summary();
           
            
            
           
           
    }
}