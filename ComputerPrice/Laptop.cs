using System;

namespace AssessmentTask3;


public class Laptop : Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt{ get;set;}
    public int RamPrice{get;}=200;
    public int HardDiskPrice{get;}=1500;
    public int GraphicCardPrice{get;}=2500;
    public int DisplayPrice{get;}=250;
    public int BatteryPrice{get;}=20;

    int processorCost=0;
    public double LaptopPriceCalculation()
    {
        
             if(Processor=="i3")
            {
                processorCost=2500;
            }
            else if(Processor=="i5")
            {
                processorCost=5000;
            }
            else if(Processor=="i7")
            {
                processorCost=6500;
            }
           
           double  laptopPrice=processorCost+(RamSize*RamPrice)+(HardDiskSize*HardDiskPrice)+(GraphicCard*GraphicCardPrice)+(DisplaySize*DisplayPrice)+(BatteryVolt*BatteryPrice);
            return laptopPrice;
    }
}