using LPU_Common;
using System.Collections.Generic;
using LPU_Entity;
using LPU_DAL;
using LPU_Exceptions;
namespace LPU_BL
{
    public class StudentBL : IStudentCRUD
    {
        StudentDAO sDao = null;
        public StudentBL()
        {
            sDao = new StudentDAO();
        }
        public bool DropStudentDetails(int id)
        {
            if(id<=0)
            {
                throw new LpuException("Invalid Student ID");
            }
            bool result=sDao.DropStudentDetails(id);
            if(!result)
            {
                throw new LpuException("Student not found");
            }
            return true;
        }

        public bool EnrollStudent(Student sObj)
        {
            if(sObj==null)
            {
                throw new LpuException("Student object cannot be null");
            }
            if(sObj.StudentID<=0)
            {
                throw new LpuException("Invalid StudentID");
                
            }
            if(string.IsNullOrWhiteSpace(sObj.Name))
            {
                throw new LpuException("Student name cannot be empty");
            }
            if(!Enum.IsDefined(typeof(CourseType),sObj.Course))
            {
                throw new LpuException("Invalid course code");
            }
            Student exists=sDao.GetStudentByID(sObj.StudentID);
            if(exists!=null)
            {
                throw new LpuException("Student ID already exists");
            }
            return sDao.EnrollStudent(sObj);
        }

        public Student SearchStudentByID(int rollNo)
        {
            Student s1 =null;
            try
            {
                s1=sDao.SearchStudentByID(rollNo);
                
            }catch (LpuException e)
            {
                throw e;
            }

            return s1;
        }

       
        public List<Student> SearchStudentByName(string name)
        {
            return sDao.SearchStudentByName(name);
        }

        

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            if(id<=0)
            {
                throw new LpuException("Invalid StudentID");
            }
            if(newObj==null)
            {
                throw new LpuException("Student data cannot be null");
            }
            Student existing = sDao.SearchStudentByID(id);
            if(existing==null)
            {
                throw new LpuException("Student not found");
            }
            return sDao.UpdateStudentDetails(id, newObj);
        }
    }
}
