namespace MethodOverloading;
class Program
{
    public static void Main()
    {
        Source sourceObj=new Source();
        System.Console.WriteLine(sourceObj.Add(45,67,34));
        System.Console.WriteLine(sourceObj.Add(9.76,67.98,23.49));
    }
}