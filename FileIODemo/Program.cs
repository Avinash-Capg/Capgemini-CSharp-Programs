// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using FileIODemo;

DirectoryDemo dObj=new DirectoryDemo();
//dObj.DirectoryDemoFunc("LPU");
//dObj.DriveInfoFunc("C:\\");
//dObj.PathDemoFunc();
FileStreamDemo fsDemoObj=new FileStreamDemo();
//fsDemoObj.CreateFile(@"C:\Users\NewData.txt");
fsDemoObj.ReadFile(@"C:\Finish.txt");
