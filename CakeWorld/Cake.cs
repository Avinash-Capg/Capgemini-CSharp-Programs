using System;

namespace Assignment4;

public class Cake
{
    public string Flavour { get; set; }
    public int QuantityInKg { get; set; }
    public double PricePerKg { get; set; }
     
    public double VanillaDiscount{get;}=3;
    public double ChocolateDiscount{get;}=5;
    public double RedVelvetDiscount{get;}=10;

    
    double totalPrice=0;
    double discount=0;
    double discountedPrice=0;
    public bool CakeOrder()
    {
        
        if(Flavour=="Chocolate" || Flavour=="Red Velvet" || Flavour=="Vanilla" )
        {
            if(QuantityInKg>0)
            {
                    return true;
            }
            else
            {
                throw new InvalidQuantityException("Quantity must be greater than zero");
                
                
            }
           
        }else
        {
           
            throw new InvalidFlavourException("Flavour not available. Please select the available flavour");
        }
      
       return false;
    }
    public double CalculatePrice()
    {
        totalPrice=QuantityInKg*PricePerKg;
        if(Flavour=="Vanilla")
        {
            discount=VanillaDiscount/100;
        }
        else if(Flavour=="Chocolate")
        {
            discount=ChocolateDiscount/100;
        }
         if(Flavour=="Red Velvet")
        {
            discount=RedVelvetDiscount/100;
        }
        discountedPrice=totalPrice-(totalPrice*discount);
        return discountedPrice;
    }
  
}
public class InvalidFlavourException: Exception
{
    public InvalidFlavourException(string message):base(message)
    {
        
    }
}
public class InvalidQuantityException : Exception
{
    public InvalidQuantityException(string message) : base(message)
    {
        
    }
}