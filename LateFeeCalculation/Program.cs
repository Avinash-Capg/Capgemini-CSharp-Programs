using System;
using System.Globalization;
namespace LateFeeCalculation;
class Program
{
    public static void Main()
    {
        
        System.Console.WriteLine("Enter the title");
        string title=Console.ReadLine();

        System.Console.WriteLine("Enter the author");
        string author=Console.ReadLine();

        System.Console.WriteLine("Enter the number of pages");
        int numPages=Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the due date");
        string input1=Console.ReadLine();
        //here DateTime is in format "MM/dd/yyyy so explicitly need to convert by taking input as string
        DateTime dueDate;
        DateTime.TryParseExact(
            input1,
            "MM/dd/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out dueDate
        );

        System.Console.WriteLine("Enter the return date");
        string input2= Console.ReadLine();

        DateTime returnedDate;
        DateTime.TryParseExact(
            input2,
            "MM/dd/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out returnedDate
        );
        System.Console.WriteLine("Enter the days to read");
        int daysToRead=Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the daily late feeRate");
        double dailyLateFeeRate=double.Parse(Console.ReadLine());
        Book bookObj=new Book(title,author,numPages,dueDate,returnedDate);

        System.Console.WriteLine($"Average Pages Read Per Day: {bookObj.AveragePagesReadPerDay(daysToRead)}");
        System.Console.Write($"Late Fee: {bookObj.CalculateLateFee(dailyLateFeeRate)}");
        

    }
}