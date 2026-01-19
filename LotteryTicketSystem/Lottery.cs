using System;
using System.Collections.Generic;
namespace LotteryTicketSystem;

public class Lottery
{
    public event EventHandler<CustomEventArgs> LotteryEvent;
    
    private List<Guid> lotteryList=new List<Guid>();
    public Lottery()
    {
        LotteryEvent+=GenerateTickets;
    }
    public void StartLottery(int quantity)
    {
        LotteryEvent?.Invoke(this,new CustomEventArgs {Quantity=quantity});
    }
    void GenerateTickets(object sender,CustomEventArgs eventArgs)
    {
       
        if (eventArgs.Quantity<10)
        {
            throw new InvalidOperationException("Minimum 10 tickets required");
        }
        lotteryList.Clear();
        int counter=0;
        while(counter<eventArgs.Quantity)
        {
            
            lotteryList.Add(Guid.NewGuid());
            counter++;
        }
        
        
    }
    public IList<Guid> LotteryWinners()
    {
        if(lotteryList.Count==0)
        {
            throw new InvalidOperationException("No Tickets generated");
        }
        return lotteryList.OrderBy(x=>Guid.NewGuid()).Take(3).ToList();//here Guid.NewGuid() for random shuffling of tickets
    }



}
