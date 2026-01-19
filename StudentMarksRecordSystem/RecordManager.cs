using System;

namespace StudentMarksRecordSystem;

public class RecordManager<T> where T :StudentRecord
{
    public List<T> recordList=new List<T>();
    public bool AddRecord(T record)
    {
        if(record==null)
        {
            return false;
        }
        StudentRecord recordObj=recordList.Find(s=>s.RecordId==record.RecordId);
        if(recordObj!=null)
        {
            return false;
        }
        recordList.Add(record);
        return true;
    }

    public void DisplayAllRecords()
    {
        foreach(T record in recordList)
        {
            System.Console.WriteLine(record.GetDetails());
        }
    }

    public double CalculateTotalMarks()
    {
        double total=0;
        foreach(T record in recordList )
        {
            total+=record.Marks;
        }
        return total;
    }

}
