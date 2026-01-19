
namespace PersonDetails;
class Program
{
    public static void Main()
    {
        IList<Person> p=new List<Person>();
        p.Add(new Person{Name = "Aarya",Address="A2101",Age=69});
        p.Add(new Person{Name = "Daniel",Address="D104",Age=40});
        p.Add(new Person{Name = "Ira",Address="H801",Age=25});
        p.Add(new Person{Name = "Jennifer",Address="I1704",Age=33});
        PersonImplementation personObj=new PersonImplementation();
        Console.WriteLine(personObj.GetName(p));
        Console.WriteLine(personObj.Average(p));
        Console.WriteLine(personObj.Max(p));
    }
}