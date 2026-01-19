using System.IO;

namespace FileIODemo;

public class DirectoryDemo
{
    public void DirectoryDemoFunc(string directoryName)
    {
       if(Directory.Exists(directoryName))
        {
            System.Console.WriteLine("Folder Already Exist...");
        }
        else
        {
            Directory.CreateDirectory(directoryName);
            System.Console.WriteLine("Folder created...");
        }
    }
    public void DriveInfoFunc(string driveName)
    {
        DriveInfo dInfo=new DriveInfo(driveName);
        System.Console.WriteLine($"Drive Name: {dInfo.Name}");
        System.Console.WriteLine($"Drive File System: {dInfo.DriveType}");
        System.Console.WriteLine($"Drive Size: {dInfo.TotalSize}");
        System.Console.WriteLine($"Drive Free Space: {dInfo.AvailableFreeSpace}");
    }
    public void PathDemoFunc()
    {
        string s=@"C:\temp\MyData.text\machine.config\Alok\Dummy.Data\ABC.cs
        ";//@ is used to avoid \\ so it'll identify the path seperator
        System.Console.WriteLine(Path.GetFileName(s));
        System.Console.WriteLine(Path.GetTempPath());
    }
    
    }
