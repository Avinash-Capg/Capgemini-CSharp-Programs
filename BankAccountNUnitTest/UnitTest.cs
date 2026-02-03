using NUnit.Framework;
using System;

[TestFixture]
public class UnitTest
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
     
        Program acc = new Program(1000m);

   
        acc.Deposit(500m);

       
        Assert.AreEqual(1500m, acc.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
       
        Program acc = new Program(1000m);

       
        Assert.AreEqual("Deposit amount cannot be negative",
            Assert.Throws<Exception>(() => acc.Deposit(-200m)).Message);
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
      
        Program acc = new Program(1000m);

  
        acc.Withdraw(300m);

      
        Assert.AreEqual(700m, acc.Balance);
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {

        Program acc = new Program(500m);


        Assert.AreEqual("Insufficient funds.",
            Assert.Throws<Exception>(() => acc.Withdraw(800m)).Message);
    }
}