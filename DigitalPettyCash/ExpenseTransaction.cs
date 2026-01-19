using System;

namespace DigitalPettyCash;

public class ExpenseTransaction : Transaction
{
    public string Category { get; set; }

    public ExpenseTransaction(int id,  double amount, string description, string category)
        : base(id, amount, description)
    {
        Category = category;
    }

    public override string GetSummary()
    {
        return $" EXPENSE | {Category} | {Amount} | {Description}";
    }
}
