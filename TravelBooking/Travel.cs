using System;

namespace Assignment2;

public class Travel
{
    public static void TravelBooking()
    {
        System.Console.Write("Enter Passenger ID: ");
        int pID=Int32.Parse(Console.ReadLine());

        System.Console.Write("Enter Passenger Name: ");
        string name=Console.ReadLine();

        System.Console.Write("Enter Age: ");
        int age=Int32.Parse(Console.ReadLine());
        if(age<5)
        {
            System.Console.WriteLine("Free Ticket - No Booking Required");
            return;
        }
        else if(age>80)
        {
            System.Console.WriteLine("Medical Clearance Required");
            return;
        }else{

        System.Console.Write("Enter Travel Type (1-Bus, 2-Train, 3-Flight): ");
        int travelType=Int32.Parse(Console.ReadLine());

        System.Console.Write("Enter Base Fare: ");
        int baseFare=Int32.Parse(Console.ReadLine());

        System.Console.Write("Is Government Employee (true/false): ");
        bool govEmp=bool.Parse(Console.ReadLine());
 
        
        if(travelType==1)
        {
            System.Console.Write("Enter Bus Class (1-Sleeper,2-Seater): ");
            
        }
        else if(travelType==2)
        {
            System.Console.Write("Enter Train Class (1-General,2-Sleeper,3-AC): ");
            
        }
        else if(travelType==3)
        {
            System.Console.Write("Enter Flight Class (1-Economy,2-Business): ");
            
        }
        int classType=Int32.Parse(Console.ReadLine());
        
        string className="";
        double fairMultiplier=0;
        
    switch(travelType)
    {
        
            case 1:
                {
                    switch(classType)
                    {
                        case 1 :
                        {
                            className="Sleeper";
                            fairMultiplier=1.2;
                            break;       
                        }
                        case 2 :
                        {
                            className="Seater";
                            fairMultiplier=1.0;
                            break;       
                        }
                    }
                    break;
                }
            case 2:
                {
                    switch(classType)
                    {
                        case 1 :
                        {
                            className="General";
                            fairMultiplier=1.0;
                            break;       
                        }
                        case 2 :
                        {
                            className="Sleeper";
                            fairMultiplier=1.3;
                            break;       
                        }
                        case 3 :
                        {
                            className="AC";
                            fairMultiplier=1.6;
                            break;       
                        }

                        
                    }
                    break;
                }
            case 3:
                {
                    switch(classType)
                    {
                        case 1 :
                        {
                            className="Economy";
                            fairMultiplier=2.5;
                            break;       
                        }
                        case 2 :
                        {
                            className="Business";
                            fairMultiplier=3.5;
                            break;       
                        }
                    }
                    break;
                }
    }
    
        double totalFare=baseFare*fairMultiplier;
        
        double discount=0;
        double resFare=0;
        double discountAmount=0;
        if(age>=60)
        {
            discount=30;
            discountAmount=totalFare*discount/100;
            
        }
        else if(govEmp)
        {
            discount=15;
            discountAmount=totalFare*discount/100;

        }
        else if(age>=5 && age<=12)
        {
            discount=50;
            discountAmount=totalFare*discount/100;
        }
        else
        {
            discount=0;
            discountAmount=0;
        }
        resFare=totalFare-discountAmount;
        string bookingStatus="";
        if(resFare>=10000)
        {
            if(travelType==3)
            {
                bookingStatus="Confirmed";
            }
            else
            {
                bookingStatus="Waiting List";
            }
        }
        else
        {
            bookingStatus="Confirmed";
        }



        System.Console.WriteLine("Display Ticket Summary");
        System.Console.WriteLine("==========================");
        System.Console.WriteLine($"Passenger ID: {pID}");
        System.Console.WriteLine($"Passenger Name: {name}");
        System.Console.WriteLine($"Age: {age}");
        System.Console.WriteLine($"Travel Type: {travelType}");
        System.Console.WriteLine($"Class: {className}");
        System.Console.WriteLine($"Base Fare: {baseFare}");
        System.Console.WriteLine($"Final Fare: {resFare}");
        System.Console.WriteLine($"Discount Applied: {discount}%");
        System.Console.WriteLine($"Booking Status: {bookingStatus}");
           }
        }
    }

