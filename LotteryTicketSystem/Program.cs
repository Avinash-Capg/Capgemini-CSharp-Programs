using System;
using LotteryTicketSystem;
namespace LotteryTicketSystem;
class Program
{
    public static void Main()
    {
        try
        {
            Lottery lottery=new Lottery();
            System.Console.Write("Enter number of tickets: ");
            int quantity=Convert.ToInt32(Console.ReadLine());

            lottery.StartLottery(quantity);
            var winners=lottery.LotteryWinners();
            int i=1;
            foreach(var winner in winners)
            {
                System.Console.WriteLine($"{i}. {winner}");
                i++;
            }
        }catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
} 