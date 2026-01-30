using System;

namespace CalculateNumbers;
class Program
{
    public  static  List<int> NumberList=new List<int>();
   
    public void AddNumbers(int Numbers)
    {
        NumberList.Add(Numbers);
    }
    public double GetGPAScored()
    {
        if(NumberList.Count==0)
        {
            return -1;
        }
        int credit=3;
        int sum=0;
        foreach(int item in NumberList)
        {
            sum=sum+item*credit;
        }
        double gpa=(double)sum/(NumberList.Count*credit);
        return gpa;
    }
    public char GetGradeScored(double gpa)
    {
        char grade;
       if(gpa>=5 && gpa<6)
        {
            grade='E';
        }
         else if(gpa>=6 && gpa<7)
        {
            grade='D';
        }
         else if(gpa>=7 && gpa<8)
        {
            grade='C';
        }
         else if(gpa>=8 && gpa<9)
        {
            grade='B';
        }
         else if(gpa>=9 && gpa<10)
        {
            grade='A';
        }
         else if(gpa==10)
        {
            grade='S';
        }
        else
        {
            return '\0';
        }
        return grade;

    }
    public static void Main()
    {
        Program pObj=new Program();
        System.Console.Write("Enter the count of numbers you need to store: ");
        int count=Int32.Parse(Console.ReadLine());
        for(int i=1;i<=count;i++)
        {
            System.Console.Write($"Enter Number {i}: ");
            int num=Int32.Parse(Console.ReadLine());
            pObj.AddNumbers(num);
        }
        double gpa=pObj.GetGPAScored();
        if(gpa==-1)
        {
            System.Console.WriteLine("No Numbers Available");
            
        }
       
        else
        {
            
            char grade=pObj.GetGradeScored(gpa);
            if(grade=='\0')
            {
                System.Console.WriteLine("Invalid GPA");
            }
            else
            {
                System.Console.WriteLine($"GPA Scored: {gpa}");
                System.Console.WriteLine($"Grade Scored: {grade}");
            }
        }
       

        
    }

}