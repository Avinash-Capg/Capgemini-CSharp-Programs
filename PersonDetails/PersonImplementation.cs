using System;
using System.Linq;
namespace PersonDetails;

public class PersonImplementation
{
    public string GetName(IList<Person> person)
    {
        return string.Join(" ",person.Select(p=>p.Name+" "+p.Address));
        

    }
     public double Average(IList<Person> person)
    {
       return person.Average(p=>p.Age);
       
        
    }
     public int Max(IList<Person> person)
    {
        return person.Max(p=>p.Age);
        
    }
}
