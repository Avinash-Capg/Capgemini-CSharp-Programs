using System;
using System.Collections.Generic;
namespace DigitalPettyCash;
class Program
{
   
    static void Main()
    {
       
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
  
        incomeLedger.AddEntry(new IncomeTransaction(
            1,
            500,
            "Petty cash replenishment",
            "Main Cash"
        ));

        
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        expenseLedger.AddEntry(new ExpenseTransaction(
            1,        
            20,
            "Stationary",
            "Office"
        ));

        expenseLedger.AddEntry(new ExpenseTransaction(
            2,
            15,
            "Team Snacks",
            "Food"
        ));

       
        double totalIncome = incomeLedger.CalculateTotal();
        double totalExpense = expenseLedger.CalculateTotal();
        double netBalance = totalIncome - totalExpense;


        List<Transaction> result = new List<Transaction>();
        result.AddRange(incomeLedger.GetAll());
        result.AddRange(expenseLedger.GetAll());

        foreach (Transaction t in result)
        {
            Console.WriteLine(t.GetSummary()); 
        }


        Console.WriteLine($"Total Income  : {totalIncome}");
        Console.WriteLine($"Total Expense : {totalExpense}");
        Console.WriteLine($"Net Balance   : {netBalance}");
    
  
    }
}
