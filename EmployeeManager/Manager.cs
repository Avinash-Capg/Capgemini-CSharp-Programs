using System;

namespace Day4OopDemo;

public class Manager : Employee
{
    public int ManagerID { get; set; }
    public int Incentives { get; set; }
    public override int CalculateSalary(int sal)
    {
        int mySal=0;
        //NetSalary=Salary+HRA+TA+DA-PF
        mySal=(sal+35000+12000+4500-8500);
        return mySal;
    }
}
