using System;

namespace Assessment;

public class PatientBill
{
    public string BillId{ get; set; }
    public string PatientName{ get; set; }
    public bool HasInsurance{ get; set; }
    public double ConsultationFee{ get; set; }
    public double LabCharges{ get; set; }
    public double MedicineCharges{ get; set; }
    public double GrossAmount;
    public double DiscountAmount;
    public double FinalPayable;
    public static PatientBill LastBill;
    public static bool HasLastBill;
    
    public double GrossAmountCalculate(double consultationFee,double labCharges,double medicineCharges)
    {
        GrossAmount=consultationFee+labCharges+medicineCharges;
        return GrossAmount;

    }

     public double DiscountAmountCalculate(double grossAmount,double discount)
    {
        DiscountAmount=grossAmount*(discount/100);
        return DiscountAmount;

    }
    
}
