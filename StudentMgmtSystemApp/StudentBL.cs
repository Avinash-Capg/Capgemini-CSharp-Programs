using System;

namespace StudentMgmtSystemApp;

public class StudentBL
{   
    Student sObj=null;
    public StudentBL()
    {
        sObj=new Student();
    }
    public void AcceptStudentDetails()


    {
        Console.ForegroundColor=ConsoleColor.DarkGreen;
        System.Console.WriteLine("   Student Management System   ");
        System.Console.WriteLine("====================================");
        
        Console.ForegroundColor=ConsoleColor.Cyan;
        try{
            System.Console.WriteLine("Enter your RollNo:");
            sObj.RollNo=Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Name:");
            sObj.Name=Console.ReadLine();

            System.Console.WriteLine("Enter your RollNo:");
            sObj.Address=Console.ReadLine();

            System.Console.WriteLine("Enter your Physics Marks:");
            sObj.Phy=Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Chemistry Marks:");
            sObj.Chem=Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter your Maths Marks:");
            sObj.Maths=Int32.Parse(Console.ReadLine());
        }
        catch(InvalidMarksException e)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            System.Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            System.Console.WriteLine(e.Message);
        }
       
        Console.ForegroundColor=ConsoleColor.White;

    }



    public int CalcTotal()
    {
        sObj.Total=sObj.Phy+sObj.Chem+sObj.Maths;
        return sObj.Total;
        
    }


    public float CalcAvg()
    {
        sObj.Percentage=sObj.Total/3;
        return sObj.Percentage;
    }


    public void CalcResult(out int myTotal,out float myPerc)
    {
        myTotal=sObj.Phy+sObj.Chem+sObj.Maths;
        myPerc=myTotal/3;
    }


}
