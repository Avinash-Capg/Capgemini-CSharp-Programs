using System;
using LPU_BL;
using LPU_Entity;
using LPU_Exceptions;
using System.Collections.Generic;
using System.Drawing;
namespace LPU_UI
{
    class Program
    {
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student Management System");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===========================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Search Student By ID ");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Add Student Details");
            Console.WriteLine("4. Update Student Details");
            Console.WriteLine("5. Drop Student Details");
            Console.WriteLine("6. Exit");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Main(string[] args)
        {
            StudentBL sblObj = null;
            sblObj = new StudentBL();
            do
            {
                Menu();
                int choice = 0;
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write("\nPlease Enter Your Choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:// Search Student By ID
                        {
                            int id = 0;
                            try
                            {
                                
                                Console.Write("Enter Student ID for Search: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Student sObj = sblObj.SearchStudentByID(id);
                                if (sObj != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("ID\t| Name\t| Course\t| Address");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("====================================");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t| {sObj.Course}\t| {sObj.Address}");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("=====================================\n");
                                   
                                }
                            }
                            catch (LpuException e)//Custom Exception
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 2:// Show All Students
                        {
                            try
                            {
                                Console.Write("Enter Student Name for Search: ");
                                string name = Console.ReadLine();
                                List<Student> studList = sblObj.SearchStudentByName(name);
                                if (studList != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("ID\t| Name\t| Course\t| Address");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("====================================");

                                    foreach (var sObj in studList)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t| {sObj.Course}\t| {sObj.Address}\n");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                }
                            }catch(LpuException e)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(e.Message);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            }
                                break;
                        }
                    case 3://Add Student Details
                        {
                            try

                            {
                                Student sObj = new Student();
                                Console.WriteLine("Enter Student details to add ");
                                Console.Write("Enter StudentID: ");
                                sObj.StudentID = Int32.Parse(Console.ReadLine());

                                Console.Write("Enter Student Name: ");
                                sObj.Name = Console.ReadLine();

                                Console.WriteLine("Select Course:\n10 - Mechanical\n20 - Electrical\n30 - Civil\n40 - CSE\n50 - IT ");
                                Console.Write("Enter Course Code: ");

                                int course = Int32.Parse(Console.ReadLine());
                                sObj.Course = (CourseType)course;

                                Console.Write("Enter address: ");
                                sObj.Address = Console.ReadLine();

                                bool result = sblObj.EnrollStudent(sObj);
                                if(result)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Student added successfully!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                            }catch(LpuException ex)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(ex.Message);
                                Console.ForegroundColor= ConsoleColor.White;
                            }
                            catch(Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(e.Message);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        }
                    case 4://Update Student Details
                        {
                            try
                            {
                                Student sObj= new Student();
                                Console.WriteLine("Enter StudentID to update");
                                Console.Write("Enter StudentID: ");
                                int sID = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter updated name: ");
                                sObj.Name = Console.ReadLine();
                                Console.WriteLine("Select Course:\n10 - Mechanical\n20 - Electrical\n30 - Civil\n40 - CSE\n50 - IT ");
                                Console.Write("Enter updated course: ");
                                int course = Convert.ToInt32(Console.ReadLine());
                                if(!Enum.IsDefined(typeof(CourseType),course))
                                {
                                    throw new LpuException("Invalid Course selected");
                                }
                                sObj.Course = (CourseType)course;
                                Console.Write("Enter updated address: ");
                                sObj.Address = Console.ReadLine();
                                bool result = sblObj.UpdateStudentDetails(sID, sObj);
                                if(result)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Student details updated successfully");
                                    Console.ForegroundColor=ConsoleColor.White;
                                }
                            }
                            catch(LpuException e)
                            {
                                Console.ForegroundColor=ConsoleColor.DarkRed;
                                Console.WriteLine(e.Message);
                                Console.ForegroundColor=ConsoleColor.White;
                            }
                            catch(Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(e.Message);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        }
                    case 5://Drop Student Details
                        {
                            try
                            {
                                Console.WriteLine("Enter student details to delete");
                                Console.Write("Enter StudentID: ");
                                int sID = Int32.Parse(Console.ReadLine());
                                bool result = sblObj.DropStudentDetails(sID);
                                if(result)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Student dropped successfully\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                            }
                            catch(LpuException e)
                            {
                                Console.ForegroundColor=ConsoleColor.DarkRed;
                                Console.WriteLine(e.Message);
                                Console.ForegroundColor= ConsoleColor.White;
                            }
                            catch(Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("System Error: "+e.Message);
                                Console.ForegroundColor= ConsoleColor.White;
                            }
                            break;
                        }
                    case 6://Exit from application
                        {

                            return;
                        }
                    default:
                        break;
                }

            } while (true);
        }
    }
}