using System;
using System.Collections.Generic;
namespace DigitalPettyCash;
public class Ledger<T> where T : Transaction
{
    private List<T> transactions = new List<T>();

    public void AddEntry(T entry)
    {
        transactions.Add(entry);
    }


   
    public double CalculateTotal()
    {
        double total = 0;

        foreach (T transaction in transactions)
        {
            total =total+transaction.Amount;
        }

        return total;
    }

    public List<T> GetAll()
    {
        return transactions;
    }
}



