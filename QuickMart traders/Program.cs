using System;
namespace Assessment2;
class Program
{
    public static void Main()
    {
        bool condition=true;
        while(condition==true){
            System.Console.WriteLine("==============QuickMart Traders=============");
            System.Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)\n2. View Last Transaction\n3. Calculate Profit/Loss (Recompute & Print)\n4. Exit");
            System.Console.Write("Enter your option: ");
            int option=Int32.Parse(Console.ReadLine());
            SaleTransaction salesObj=new SaleTransaction();
            
            if(option==1)
            {
                System.Console.Write("\nEnter Invoice No: ");
                salesObj.InvoiceNo=Console.ReadLine();

                System.Console.Write("Enter Customer Name: ");
                salesObj.CustomerName=Console.ReadLine();

                System.Console.Write("Enter Item Name: ");
                salesObj.ItemName=Console.ReadLine();
            

                System.Console.Write("Enter Quantity:  ");
                salesObj.Quantity=Int32.Parse(Console.ReadLine());

                System.Console.Write("Enter Purchase Amount: ");
                salesObj.PurchaseAmount=double.Parse(Console.ReadLine());

                System.Console.Write("Enter Selling Amount: ");
                salesObj.SellingAmount=double.Parse(Console.ReadLine());
                if(salesObj.InvoiceNo!=null)
                {
                    if(salesObj.Quantity>0 && salesObj.PurchaseAmount>0 &&  salesObj.SellingAmount>=0 )
                    {
                        if(salesObj.SellingAmount>salesObj.PurchaseAmount)
                        {
                            salesObj.ProfitOrLossStatus="PROFIT";
                            salesObj.ProfitOrLossAmount=salesObj.SellingAmount-salesObj.PurchaseAmount;
                        }
                        else if(salesObj.SellingAmount<salesObj.PurchaseAmount)
                        {
                            salesObj.ProfitOrLossStatus="LOSS";
                            salesObj.ProfitOrLossAmount=salesObj.PurchaseAmount-salesObj.SellingAmount;
                        }
                         else if(salesObj.SellingAmount==salesObj.PurchaseAmount)
                        {
                            salesObj.ProfitOrLossStatus="BREAK-EVEN";
                            salesObj.ProfitOrLossAmount=0;
                        }

                    }
                    salesObj.ProfitMarginPercent=(salesObj.ProfitOrLossAmount/salesObj.PurchaseAmount)*100;
                    System.Console.WriteLine("\nTransaction saved successfully.");
                    System.Console.WriteLine($"Status: {salesObj.ProfitOrLossStatus}");
                    System.Console.WriteLine($"Profit/Loss Amount: {salesObj.ProfitOrLossAmount:F2}");
                    System.Console.WriteLine($"Profit Margin (%): {salesObj.ProfitMarginPercent:F2}");
                    System.Console.WriteLine("--------------------------------------------------------");
                    SaleTransaction.LastTransaction=salesObj;
                    SaleTransaction.HasLastTransaction=true;
                }
        
            }else if(option==2)
            {

                if(!SaleTransaction.HasLastTransaction || SaleTransaction.LastTransaction==null)
                {
                    System.Console.WriteLine( "No transaction available. Please create a new transaction first.");
                }
                else
                {
                    SaleTransaction lastbillObj=SaleTransaction.LastTransaction;
                    System.Console.WriteLine("\n-----------Last Transaction-------------------");
                    System.Console.WriteLine($"InvoiceNo: {lastbillObj.InvoiceNo}");
                    System.Console.WriteLine($"Customer: {lastbillObj.CustomerName}");
                    System.Console.WriteLine($"Item: {lastbillObj.ItemName}");
                    System.Console.WriteLine($"Quantity: {lastbillObj.Quantity}");
                    System.Console.WriteLine($"Purchase Amount: {lastbillObj.PurchaseAmount}");
                    System.Console.WriteLine($"Selling Amount: {lastbillObj.SellingAmount:F2}");
                    System.Console.WriteLine($"Status: {lastbillObj.ProfitOrLossStatus:F2}");
                    System.Console.WriteLine($"Profit/Loss Amount: {lastbillObj.ProfitOrLossAmount:F2}");
                    System.Console.WriteLine($"Profit Margin (%): {lastbillObj.ProfitMarginPercent:F2}");
                    System.Console.WriteLine("-------------------------------------------------------------");
                }
                
            }
            else if(option==3)
            {
                if(!SaleTransaction.HasLastTransaction || SaleTransaction.LastTransaction==null)
                {
                    System.Console.WriteLine("No transaction available. Please create a new transaction first.");
                }
                else
                {
                     SaleTransaction lastObj = SaleTransaction.LastTransaction;

                    if (lastObj.SellingAmount > lastObj.PurchaseAmount)
                    {
                        lastObj.ProfitOrLossStatus = "PROFIT";
                        lastObj.ProfitOrLossAmount = lastObj.SellingAmount - lastObj.PurchaseAmount;
                    }
                    else if (lastObj.SellingAmount < lastObj.PurchaseAmount)
                    {
                        lastObj.ProfitOrLossStatus = "LOSS";
                        lastObj.ProfitOrLossAmount = lastObj.PurchaseAmount - lastObj.SellingAmount;
                    }
                    else
                    {
                        lastObj.ProfitOrLossStatus = "BREAK-EVEN";
                        lastObj.ProfitOrLossAmount = 0;
                    }

                    lastObj.ProfitMarginPercent =(lastObj.ProfitOrLossAmount / lastObj.PurchaseAmount) * 100;

                    Console.WriteLine($"Status: {lastObj.ProfitOrLossStatus}");
                    Console.WriteLine($"Profit/Loss Amount: {lastObj.ProfitOrLossAmount:F2}");
                    Console.WriteLine($"Profit Margin (%): {lastObj.ProfitMarginPercent:F2}");
                    Console.WriteLine("------------------------------------------------------");
                }
                
            }
            else if(option==4)
            {
                System.Console.WriteLine("\nThank you. Application closed normally.");
                condition=false;
            }
    }
}
}