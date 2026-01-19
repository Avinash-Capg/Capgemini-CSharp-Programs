using System;

namespace Assessment2;

public class SaleTransaction
{
    public string InvoiceNo { get; set; }
    public string CustomerName{ get; set; }
    public string ItemName{ get; set; }
    public int Quantity { get; set; }
    public double PurchaseAmount { get; set; }
    public double SellingAmount { get; set; }
    public string ProfitOrLossStatus { get; set; }
    public double ProfitOrLossAmount ;
    public double ProfitMarginPercent;
    public static SaleTransaction LastTransaction;
    public static bool HasLastTransaction;
}
