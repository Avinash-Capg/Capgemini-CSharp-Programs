using System;

namespace Assignment7;

public class CabDetails : Cab
{
    public bool ValidateBookingID()
    {
        if(BookingID.Length!=6)
        {
            return false;
        }
        if(!BookingID.StartsWith("AC@"))
        {
            
            return false;
        }
        string digitPart=BookingID.Substring(3);//index starting from 3
        bool isDigit=char.IsDigit(digitPart[0])&&char.IsDigit(digitPart[1])&&char.IsDigit(digitPart[2]);
        if(!isDigit)
        {
            return false;
        }
        return true;
    }
    public double CalculateFareAmount()
    {
        double pricePerKm=0;
        if(CabType=="Hatchback")
        {
            pricePerKm=10;
        }
        else if(CabType=="Sedan")
        {
            pricePerKm=20;
        }
        else if(CabType=="SUV")
        {
            pricePerKm=30;
        }
        double WaitingCharge=Math.Sqrt(WaitingTime);
        double fare=Distance*pricePerKm+WaitingCharge;
        return fare;
    }

}
