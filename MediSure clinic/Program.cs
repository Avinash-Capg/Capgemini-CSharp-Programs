using System;
namespace Assessment;
class Program
{
    public static void Main()
    {

        bool condition=true;
        while(condition==true){
        System.Console.WriteLine("==========MediSure Clinic Billing==========");
        System.Console.WriteLine("1. Create New Bill\n2. View Last Bill\n3. Clear Last Bill\n4. Exit");
        System.Console.Write("Enter your option: ");
        int option=Int32.Parse(Console.ReadLine());
        
   
        if(option==1)
        {
            PatientBill patientObj=new PatientBill();
            System.Console.Write("\nEnter Bill Id: ");
            patientObj.BillId=Console.ReadLine();

            System.Console.Write("Enter Patient Name: ");
            patientObj.PatientName=Console.ReadLine();

            System.Console.Write("Is the patient insured? (Y/N): ");
            string hasInsurance=Console.ReadLine();
            if(hasInsurance=="Y")
            {
                patientObj.HasInsurance=true;
            }
            else
            {
                patientObj.HasInsurance=false;
            }

            System.Console.Write("Enter Consultation Fee:  ");
            patientObj.ConsultationFee=double.Parse(Console.ReadLine());

            System.Console.Write("Enter Lab Charges: ");
            patientObj.LabCharges=double.Parse(Console.ReadLine());

            System.Console.Write("Enter Medicine Charges: ");
            patientObj.MedicineCharges=double.Parse(Console.ReadLine());
            
            if(patientObj.BillId!=null)
            {
                if(patientObj.ConsultationFee>0 && patientObj.LabCharges>=0 &&  patientObj.MedicineCharges>=0 )
                {
                    System.Console.WriteLine("\nBill created successfully.");
                    
                     patientObj.GrossAmount=patientObj.GrossAmountCalculate( patientObj.ConsultationFee,patientObj.LabCharges,patientObj.MedicineCharges);
                    System.Console.WriteLine($"Gross Amount: {patientObj.GrossAmount:F2}");

                    if(patientObj.HasInsurance)
                    {
                        double discount=10;
                      
                        patientObj.DiscountAmount=patientObj.DiscountAmountCalculate(patientObj.GrossAmount,discount);
                        System.Console.WriteLine($"Discount Amount: {patientObj.DiscountAmount:F2}");
                    }
                    else
                    {
                        patientObj.DiscountAmount=0;
                    }
                    patientObj.FinalPayable=patientObj.GrossAmount-patientObj.DiscountAmount;
                    System.Console.WriteLine($"Final Payable: {patientObj.FinalPayable:F2}");
                    System.Console.WriteLine("--------------------------------------------------------");
                    PatientBill.LastBill = patientObj;
                    PatientBill.HasLastBill = true;

                

                }   
            }
        }else if(option==2)
            {
                if(!PatientBill.HasLastBill || PatientBill.LastBill==null)
                {
                    System.Console.WriteLine("No bill available.Please create a new bill first");
                }
                else
                {
                    PatientBill billObj=PatientBill.LastBill;
                    System.Console.WriteLine("-----------Last Bill------------");
                    System.Console.WriteLine("BillId: " + billObj.BillId);
                    System.Console.WriteLine($"Patient: {billObj.PatientName}");
                    System.Console.WriteLine($"Insured: {(billObj.HasInsurance ? "Yes" :"No")}");
                    System.Console.WriteLine($"Consultation Fee: {billObj.ConsultationFee:F2}");
                    System.Console.WriteLine($"Lab Charges: {billObj.LabCharges:F2}");
                    System.Console.WriteLine($"Medicine Charges: {billObj.MedicineCharges:F2}");
                    System.Console.WriteLine($"Gross Amount: {billObj.GrossAmount:F2}");
                    System.Console.WriteLine($"Discount amount: {billObj.DiscountAmount:F2}");
                    System.Console.WriteLine($"Final Payable: {billObj.FinalPayable:F2}");

                }
            }
            else if(option==3)
            {
                PatientBill.LastBill=null;
                PatientBill.HasLastBill = false;
                System.Console.WriteLine("Last bill cleared.");
            }
            else if(option==4)
            {
                System.Console.WriteLine("\nThankyou. Application closed normally.");
                condition=false;
            }

        
        }
    }
}