using System;
using System.Runtime.ConstrainedExecution;
namespace StudentMarksRecordSystem;
class Program
{
    static void Menu()
    {
        System.Console.WriteLine("Student Marks Record System");
        System.Console.WriteLine("===========================");
        System.Console.WriteLine("1. Add Theory Student Record");
        System.Console.WriteLine("2. Add Lab Student Record");
        System.Console.WriteLine("3. Display All Records");
        System.Console.WriteLine("4. Calculate Total Marks");
        System.Console.WriteLine("5. Exit");
    }
    public static void Main(string[] args)
    {
        RecordManager<LabStudent> labObj=new RecordManager<LabStudent>();
        RecordManager<TheoryStudent> theoryObj=new RecordManager<TheoryStudent>();

        do
        {
            Menu();
            System.Console.Write("\nMenu Choice: ");
            int option=Int32.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                    {
                        
                        System.Console.Write("RecordId: ");
                        int recordId=Int32.Parse(Console.ReadLine());

                        System.Console.Write("StudentName: ");
                        string name=Console.ReadLine();

                        System.Console.Write("Marks: ");
                        int marks=Int32.Parse(Console.ReadLine());

                        System.Console.Write("SubjectName: ");
                        string subjectName=Console.ReadLine();
                        TheoryStudent obj=new TheoryStudent(recordId,name,marks,subjectName);
                        bool result=theoryObj.AddRecord(obj);
                        if(result)
                        {
                            System.Console.WriteLine("Theory Student Record Added Successfully\n");
                        }
                        else
                        {
                             System.Console.Write("Record already exists or input error \n");
                     
                        }
                        
                        break;
                    }
                case 2:
                    {
                        System.Console.Write("RecordId: ");
                        int recordId=Int32.Parse(Console.ReadLine());

                        System.Console.Write("StudentName: ");
                        string name=Console.ReadLine();

                        System.Console.Write("Marks: ");
                        int marks=Int32.Parse(Console.ReadLine());

                        System.Console.Write("SubjectName: ");
                        string labName=Console.ReadLine();
                        LabStudent obj=new LabStudent(recordId,name,marks,labName);
                        bool result=labObj.AddRecord(obj);
                        if(result)
                        {
                            System.Console.WriteLine("Lab Student Record Added Successfully\n");
                        }
                        else
                        {
                             System.Console.Write("Record already exists or input error \n");
                     
                        }
                        break;
                    }
                case 3:
                    {
                        System.Console.WriteLine("------Theory Student Records--------");
                        theoryObj.DisplayAllRecords();

                        System.Console.WriteLine("\n------Lab Student Records-----------");
                        labObj.DisplayAllRecords();
                       

                        break;
                    }
                case 4:
                    {
                        System.Console.WriteLine($"Total Theory Marks: {theoryObj.CalculateTotalMarks()}");
                        System.Console.WriteLine($"Total Lab Marks: {labObj.CalculateTotalMarks()}");
                        System.Console.WriteLine($"Overall Total Marks: {theoryObj.CalculateTotalMarks()+labObj.CalculateTotalMarks()}\n");
                        break;
                    }
                case 5:
                    {
                        System.Console.WriteLine("Exiting from application.GoodBye!");
                        return;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid option. Please enter between 1 and 5\n");
                        break;
                    }
            }
        }while(true);
    }
}
