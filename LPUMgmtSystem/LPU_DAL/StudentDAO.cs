using System;
using LPU_Common;
using LPU_Entity;
using LPU_Exceptions;
namespace LPU_DAL
{
    /// <summary>
    /// 
    /// StudentDAO claass is used for CRUD operations
    /// </summary>

    public class StudentDAO : IStudentCRUD
    {
        static List<Student> studentList = null;
       
        public StudentDAO()
        {
           
            //Collection init
            studentList = new List<Student>()
            {
                new Student(){StudentID=101,Name="Alok",Course=CourseType.CSE,Address="Chandigarh" },
                new Student(){StudentID=102,Name="Aliya",Course=CourseType.CSE,Address="Jalandhar" },
                new Student(){StudentID=103,Name="Aman",Course=CourseType.CSE,Address="Phagwara" },
                new Student(){StudentID=104,Name="Riya",Course=CourseType.CSE,Address="Delhi" },
                new Student(){StudentID=105,Name="Rajat",Course=CourseType.CSE,Address="Kochi" },
                new Student(){StudentID=106,Name="Alok",Course=CourseType.CSE,Address="Chennai" },
                new Student(){StudentID=107,Name="Devika",Course=CourseType.CSE,Address="Agra" },
                new Student(){StudentID=108,Name="Rose",Course=CourseType.CSE,Address="Phagwara" },
                new Student(){StudentID=109,Name="Riya",Course=CourseType.CSE,Address="Hyderabad" },
                new Student(){StudentID=110,Name="Swetha",Course=CourseType.CSE,Address="Thrissur" },
                new Student(){StudentID=111,Name="Alok",Course=CourseType.CSE,Address="Chandigarh" },
                new Student(){StudentID=112,Name="Aliya",Course=CourseType.CSE,Address="Jalandhar" },
                new Student(){StudentID=113,Name="Govind",Course=CourseType.CSE,Address="Bangalore" },
                new Student(){StudentID=114,Name="Riya",Course=CourseType.CSE,Address="Sonipat" },
                new Student(){StudentID=115,Name="Divya",Course=CourseType.CSE,Address="Kochi" }


            };
        }
        public bool DropStudentDetails(int id)
        {
            Student myStud=null;
            if(id!=0)
            {
                myStud = studentList.Find(s => s.StudentID == id);
                if(myStud==null)
                {
                    return false;
                }
                studentList.Remove(myStud);
                
            }
            return true;
        }
        public Student GetStudentByID(int id)
        {
            return studentList.Find(s => s.StudentID == id);
        }
        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if(sObj!=null )
            {
                
                studentList.Add(sObj);
                flag = true;
            }
            return flag;
        }
        public Student SearchStudentByID(int rollNo)
        {
            Student myStud = null;
            if(rollNo!=0)
            {
                myStud = studentList.Find(s => s.StudentID == rollNo);
                if(myStud==null)
                {
                    throw new LpuException("Student Record Not Found");                
                }
            }
            else
            {
                throw new LpuException("Error generated...");
            }
            return myStud;
        }

        public List<Student> SearchStudentByName(string name)
        {
            
            List<Student> data = studentList.FindAll(p => p.Name == name);
            if(data.Count==0)
            {
                throw new LpuException("No Student found with given name");
            }
            return data;
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            Student oldStudent = studentList.Find(s => s.StudentID == id);
            if(oldStudent!=null)
            {
                oldStudent.Name = newObj.Name;
                oldStudent.Address = newObj.Address;
                oldStudent.Course = newObj.Course;
                return true;
            }
            return false;
        }
    }
}
