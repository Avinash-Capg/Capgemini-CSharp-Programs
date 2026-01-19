// using System;
// namespace OperatorOverloadingDemo;
using OperatorOverloadingDemo;

// //primitive type
// int num1=100;
// int num2=200;
// int numResult=num1+num2;
// System.Console.WriteLine(numResult);


//reference type
Employee emp1=new Employee();
emp1.EmpID=101;
emp1.EmpName="Alok";
emp1.BSalary=40000;

Employee emp2=new Employee();
emp2.EmpID=102;
emp2.EmpName="Riya";
emp2.BSalary=35000;

Employee emp3=new Employee();
emp3.EmpID=1789;
emp3.EmpName="Manjeet";
emp3.BSalary=65000;

Employee empObj=emp1+emp2+emp3;


System.Console.WriteLine($"Total Salary Paid: {empObj.BSalary }");
