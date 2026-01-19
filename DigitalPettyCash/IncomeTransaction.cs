using System;
namespace DigitalPettyCash;
public class IncomeTransaction : Transaction
{
    public string Source { get; set; }

    public IncomeTransaction(int id, double amount, string description, string source)
        : base(id,  amount, description)
    {
        Source = source;
    }

    public override string GetSummary()
    {
        return $" INCOME | {Source} | {Amount} | {Description}";
    }
}
