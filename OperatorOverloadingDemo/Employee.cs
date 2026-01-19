using System;

namespace OperatorOverloadingDemo;

class Employee
{
    public int EmpID { get; set; }
    public string EmpName{ get; set; }
    public int BSalary { get; set; }

    public static Employee operator + (Employee e1,Employee e2)
    {
        Employee temp=new Employee();
        temp.BSalary=e1.BSalary+e2.BSalary;
        return temp;

    }
}
