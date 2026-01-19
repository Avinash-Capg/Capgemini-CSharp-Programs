using System;

namespace StudentMarksRecordSystem;

public class LabStudent:StudentRecord
{
    public string LabName { get; set; }
    public LabStudent(int recordId,string studentName,double marks,string labName):base(recordId,studentName, marks)
    {
        LabName=labName;
    }
    public override string GetDetails()
    {
        return $"Lab Student - Record Id: {RecordId} | Student Name: { StudentName} | Marks: {Marks} | Lab Name: {LabName}";
    }
}

