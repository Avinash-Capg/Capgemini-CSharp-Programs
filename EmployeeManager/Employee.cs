using System;

namespace Day4OopDemo;

public class Employee
{
    #region Properties
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public int BasicSal{get;set;}
    #endregion


    public virtual int CalculateSalary(int sal)
    {
        int mySal=0;
        //NetSalary=Salary+HRA+TA+DA-PF
        mySal=(sal+15000+3000+1500-2500);
        return mySal;
    }
}
