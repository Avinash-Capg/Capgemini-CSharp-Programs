using System;

namespace EcommerceApplication;
class Program
{
    public static void Main()
    {
        try{
            EcommerceShop ecommerceObj=new EcommerceShop();
            System.Console.Write("Enter user name: ");
            ecommerceObj.UserName=Console.ReadLine();

            System.Console.Write("Enter wallet balance: ");
            ecommerceObj.WalletBalance=double.Parse(Console.ReadLine());

            System.Console.Write("Enter total purchase amount: ");
            ecommerceObj.TotalPurchaseAmount=double.Parse(Console.ReadLine());
            
            Program pObj=new Program();
            var testObj=pObj.MakePayment(ecommerceObj.UserName, ecommerceObj.WalletBalance,ecommerceObj.TotalPurchaseAmount);
            if(testObj!=null)
            {
                System.Console.WriteLine("Payment successful");
            }
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
      

    }
    public  EcommerceShop MakePayment(string name,double balance,double amount)
    {
        EcommerceShop ecommerceShop=new EcommerceShop();
        ecommerceShop.UserName=name;
        ecommerceShop.WalletBalance=balance;
        ecommerceShop.TotalPurchaseAmount=amount;
        if(balance<amount)
        {
            throw new InsufficientBalanceException();
            
        }
        return ecommerceShop;
        

        
    }
}
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException():base()
    {
        System.Console.WriteLine("Insufficient balance in your digital wallet");
    }
}