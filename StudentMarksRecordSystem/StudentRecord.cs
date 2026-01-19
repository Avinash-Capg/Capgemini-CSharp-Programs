using System;

namespace StudentMarksRecordSystem;

public abstract class StudentRecord
{
    public int RecordId{get;set;}
    public string StudentName { get; set; }
    public double Marks{get;set;}
    protected StudentRecord(int recordId,string studentName,double marks)
    {
        RecordId=recordId;
        StudentName=studentName;
        Marks=marks;

    }
    public abstract string GetDetails();
}
