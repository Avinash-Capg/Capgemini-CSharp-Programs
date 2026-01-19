// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using StudentMgmtSystemApp;
StudentBL sBLobj=new StudentBL();
sBLobj.AcceptStudentDetails();
// sBLobj.CalcTotal();
// sBLobj.CalcAvg();
int t1;//total
float p1;//percentage
sBLobj.CalcResult(out t1,out p1);
System.Console.WriteLine($"Total: {t1}");
System.Console.WriteLine($"Percentage: {p1}");