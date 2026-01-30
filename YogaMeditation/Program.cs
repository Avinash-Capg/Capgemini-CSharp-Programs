using System;
using System.Linq;

namespace YogaMeditation;
class Program
{
   
    public void AddYogaMember(int memberId,int age,double weight,double height,string goal)
    {
        MeditationCenter mediObj=new MeditationCenter();
        mediObj.MemberID=memberId;
        mediObj.Age=age;
        mediObj.Weight=weight;
        mediObj.Height=height;
        mediObj.Goal=goal;
        MeditationCenter.memberList.Add(mediObj);

    }
   public double CalculateBMI(int memberId)
{
    foreach (var item in MeditationCenter.memberList)
    {
        MeditationCenter mediObj = (MeditationCenter)item;

        if (mediObj.MemberID == memberId)
        {
            double bmi = mediObj.Weight / (mediObj.Height * mediObj.Height);
            mediObj.BMI = bmi;
            return bmi;  
        }
    }

    
    return 0;
}

    public int CalculateYogaFee(int memberId)
    {
        int fee=0;
        foreach(var item in MeditationCenter.memberList)
        {
           MeditationCenter mediObj=(MeditationCenter)item;
           if(mediObj!=null && mediObj.MemberID==memberId)
            {
                string goal=mediObj.Goal?.Trim().ToLower();
                if(goal=="weight gain")
                {
                    fee=2500;
                }
                else if(goal=="weight loss")
                {
                    if(mediObj.BMI>=25 && mediObj.BMI<30)
                    {
                        fee=2000;
                    }
                    else if(mediObj.BMI>=30 && mediObj.BMI<35)
                    {
                        fee=2500;
                    }
                    else if(mediObj.BMI>=35)
                    {
                        fee=3000;
                    }
                }
                break;
            }
        }
        return fee;
    }
    public static void Main()
    {
        Program pObj=new Program();
        System.Console.Write("Enter Member Id: ");
        int memberId=Int32.Parse(Console.ReadLine());

        System.Console.Write("Enter Age: ");
        int age=Int32.Parse(Console.ReadLine());

        System.Console.Write("Enter Weight (in Kgs): ");
        double weight=double.Parse(Console.ReadLine());

        System.Console.Write("Enter Height (in meters): ");
        double height=double.Parse(Console.ReadLine());

        System.Console.Write("Enter Goal: ");
        string goal=Console.ReadLine();

        pObj.AddYogaMember(memberId,age,weight,height,goal);
        System.Console.WriteLine("Member details Added Successfully.\n");

        System.Console.Write("Enter member id to calculate BMI: ");
        int memberID=Int32.Parse(Console.ReadLine());
        double calculateBMI=pObj.CalculateBMI(memberID);
        if(calculateBMI==0)
        {
            System.Console.WriteLine($"MemberId {memberID} is not present");
        }
        else
        {
            System.Console.WriteLine($"BMI of the member is  {calculateBMI:F2}");
            int fees=pObj.CalculateYogaFee(memberID);
            System.Console.WriteLine($"Membership Fee: {fees}");
        }

      

    }
}