using System;


namespace AssessmentTask;

public class Employee
{
    public static void EmployeeDetails(){
        System.Console.WriteLine("Input Employee Details  ");
        System.Console.WriteLine("=======================");
        System.Console.Write("Enter Employee ID: ");
        int empID=Int32.Parse(Console.ReadLine());
        if(empID<0)
        {
            System.Console.WriteLine("Invalid ID");
            return;
        }

        System.Console.Write("Enter Employee Name: ");
        string name=Console.ReadLine();

        System.Console.Write("Enter Age: ");
        int age=Int32.Parse(Console.ReadLine());
         if(age<21)
        {
            System.Console.WriteLine("Employee is not eligibile to work");

        }else{

        System.Console.Write("Choose the Department: \n1->IT\n2->HR\n3->Finance\nEnter the department choice: ");
        int depChoice=Int32.Parse(Console.ReadLine());
        int role;
        string roleName="";
       
        if(depChoice==1)
        {
            System.Console.WriteLine("Choose role:\n1 - Developer\n2 - Tester");
            Console.Write("Enter your role choice: ");
            role=Int32.Parse(Console.ReadLine());
            if(role==1){roleName="Developer";}
            else if(role==2){ roleName="Tester";}
            else{Console.Write("Invalid Choice!");return;}


        }
        else if(depChoice==2)
        {
            System.Console.WriteLine("Choose role:\n1 - Recruiter\n2 - Payroll");
            Console.Write("Enter your role choice: ");
            role=Int32.Parse(Console.ReadLine());
            if(role==1){roleName="Recruiter";}
            else if(role==2){roleName="Payroll";}
            else{Console.Write("Invalid Choice!");return;}
        }
        else if(depChoice==3)
        {
            System.Console.WriteLine("Choose role:\n1 - Accountant\n2 - Auditor");
            Console.Write("Enter your role choice: ");
            role=Int32.Parse(Console.ReadLine());
            if(role==1){roleName="Accountant";}
            else if(role==2){roleName="Auditor";}
            else{Console.Write("Invalid Choice!");return;}

        }
        else 
        {
            Console.Write("Invalid Choice!");
            return;      
        }

        System.Console.Write("Enter Basic Salary: ");
        double basSalary=double.Parse(Console.ReadLine());  
        if(basSalary>0){
               
        double allowance=0;
        double finalSalary=0;
        string access="";
        switch(roleName)
        {
            case "Developer": allowance=30; break;
            case "Tester": allowance=25; break; 
            case "Recruiter":  allowance=20; break;  
            case "Payroll": allowance=22;  break;
            case "Accountant":  allowance=28; break;
            case "Auditor": allowance=26; break;
        }      
        finalSalary=basSalary+(basSalary*(allowance/100));
        if(depChoice==1)
        {
            if(finalSalary>=60000)
            {
                access="Admin";
            }
        }
        else 
        {
            if(finalSalary>=60000)
            {
                access="Manager";
            }
            else
            {
                access="Employee";
            }
        }
        System.Console.WriteLine("Printing Employee Details: ");
        System.Console.WriteLine("================================");
        System.Console.WriteLine($"Employee ID: {empID}");
        System.Console.WriteLine($"Name: {name}");
        if(depChoice==1)
        {
            System.Console.WriteLine("Department: IT");
        }else if(depChoice==2)
        {
            System.Console.WriteLine("Department: HR");
        }
        else if(depChoice==3)
        {
            System.Console.WriteLine("Department: Finance");
        }
        System.Console.WriteLine($"Role: {roleName}");
        System.Console.WriteLine($"Basic Salary: {basSalary}");
        System.Console.WriteLine($"Final Salary: {finalSalary}");
        System.Console.WriteLine($"Access Level: {access}");
        }
        else
        {
            System.Console.WriteLine("Invalid Salary");
            return;
        }

    }
}
}