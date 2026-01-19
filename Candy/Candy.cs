using System;

namespace Assignment5;

public class Candy
{
    public string Flavour { get; set; }
    public int Quantity{ get; set; }
    public int PricePerPiece{ get; set; }
    public double TotalPrice { get; set; }
    public double Discount{ get; set; }

    public bool ValidateCandyFlavour()
    {
        
        if(Flavour=="Strawberry"|| Flavour=="Lemon" || Flavour=="Mint")
        {
            return true;
        }
        else
        {
            System.Console.WriteLine("Invalid flavour");
            return false;
        }
        return false;
    }
   
}
