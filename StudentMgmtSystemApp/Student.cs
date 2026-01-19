using System;
using System.Dynamic;
namespace StudentMgmtSystemApp;

public class Student
{
    int rollNo;
    int phy;
    int chem;
    int maths;
    int total;
    float percentage;
    

    //CLR Properties
    public int RollNo
    {
        set
        {
            rollNo=value;//reserved keyword
        }
        get
        {
            return rollNo;
        }
        
    }

    //auto implicit property
    public string Name{get;set;}
    public string Address{get;set;}
    public int Total
    {
        get
        {
            return total;
        }
        set
        {
            total=value;
        }
    }
    public float Percentage{get;set;}
    public int Phy
    {
        get
        {
            return phy;
        }
        set
        {
            if(value>=0 && value<=100)
            {
                phy=value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
    }
     public int Chem
    {
        get
        {
            return chem;
        }
        set
        {
            if(value>=0 && value<=100)
            {
                chem=value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
    }
     public int Maths
    {
        get
        {
            return maths;
        }
        set
        {
            if(value>=0 && value<=100)
            {
                maths=value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
    }
    
}
public class InvalidMarksException : Exception
    {
        public InvalidMarksException() : base() { }

        public InvalidMarksException(string message) : base(message) { }

        public InvalidMarksException(string message, Exception innerException)
            : base(message, innerException) { }
    }