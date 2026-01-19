using System.Diagnostics;
using System.IO;

namespace FileIODemo;

public class FileStreamDemo
{
    FileStream fs=null;
    public void CreateFile(string fileName)
    {
        StreamWriter sw=null;
        try{
            fs=new FileStream(fileName,FileMode.Create,FileAccess.Write);
            sw=new StreamWriter(fs);
            sw.WriteLine("This is just a sample file for FileIODemo");
        }
        catch(FileNotFoundException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch(FileLoadException e)
        {
            System.Console.WriteLine(e.Message);
        }
        finally
        {
             sw.Close();
             fs.Close();
        }
       

    }
    public void ReadFile(string fileName)
    {
        fs=new FileStream(fileName,FileMode.Open,FileAccess.Read);
        StreamReader sr=new StreamReader(fs);
        System.Console.WriteLine(sr.ReadToEnd());
        sr.Close();
        fs.Close();


    }
}
