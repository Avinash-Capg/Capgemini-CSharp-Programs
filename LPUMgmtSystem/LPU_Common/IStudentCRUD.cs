using System;
using LPU_Entity;
using System.Collections.Generic;
namespace LPU_Common
{
    public interface IStudentCRUD
    {
        Student SearchStudentByID(int rollNo);//abstract
        List<Student> SearchStudentByName(string name);
        bool EnrollStudent(Student sObj);
        bool UpdateStudentDetails(int id, Student newObj);
        bool DropStudentDetails(int id);
    }
}
