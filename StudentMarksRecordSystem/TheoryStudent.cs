using System;

namespace StudentMarksRecordSystem;

public class TheoryStudent : StudentRecord
{
    public string SubjectName { get; set; }
    public TheoryStudent(int recordId,string studentName,double marks,string subjectName):base(recordId,studentName, marks)
    {
        SubjectName=subjectName;
    }
    public override string GetDetails()
    {
        return $"Theory Student - Record Id: {RecordId} | Student Name: { StudentName} | Marks: {Marks} | Subject Name: {SubjectName}";
    }
}

