using System;

namespace DigitalPettyCash;

using System;

public abstract class Transaction : IReportable
{
    public int Id { get; set; }
    //public DateTime Date { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; }

    protected Transaction(int id,  double amount, string description)
    {
        Id = id;
        //Date = date;
        Amount = amount;
        Description = description;
    }

    public abstract string GetSummary();
}
