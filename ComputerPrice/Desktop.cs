using System;

namespace AssessmentTask3;

public  class Desktop : Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt{ get; set; }
    public int RamPrice{get;}=200;
    public int HardDiskPrice{get;}=1500;
    public int GraphicCardPrice{get;}=2500;
    public int MonitorPrice{get;}=250;
    public int PowerSupplyPrice{get;}=20;
   int processorCost=0;

    public double DesktopPriceCalculation()
    {
        
       
          
            if(Processor=="i3")
            {
                processorCost=1500;
            }
            else if(Processor=="i5")
            {
                processorCost=3000;
            }else if(Processor=="i7")
            {
                processorCost=4500;
            }
            double desktopPrice=processorCost+(RamSize*RamPrice)+( HardDiskSize*HardDiskPrice)+(GraphicCard*GraphicCardPrice)+(MonitorSize*MonitorPrice)+(PowerSupplyVolt*PowerSupplyPrice);
            return desktopPrice;

    }
}
