// See https://aka.ms/new-console-template for more information
using System;
namespace NewConsole;
class Program
{
    static void Main()
    {
        // List<Student> studentList=new List<Student>()
        // {
        //     new Student(){StudentId=1,StudentName="Devika",CourseName="Dotnet"},
        //     new Student(){StudentId=2,StudentName="Janvi",CourseName="Java"},
        //     new Student(){StudentId=3,StudentName="Swetha",CourseName="Python"}
            
        // };
        // foreach(Student student in studentList)
        // {
        //     System.Console.WriteLine($"ID: {student.StudentId}  Name: {student.StudentName} Course: {student.CourseName}");
        // }




        Dictionary<int,string> students=new Dictionary<int,string>();
        students.Add(1,"Devika");
        students.Add(2,"Janvi");
        students.Add(3,"Bhavya");
        System.Console.Write("Enter roll no: ");
        int rollNo=Int32.Parse(Console.ReadLine());
        if(students.ContainsKey(rollNo))
        {
            System.Console.WriteLine($"Student's Name: {students[rollNo]}");
        }
        else
        {
            System.Console.WriteLine("Student not found");
        }
    }
    
}