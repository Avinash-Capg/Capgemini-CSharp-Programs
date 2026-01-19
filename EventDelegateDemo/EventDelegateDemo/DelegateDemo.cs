using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegateDemo
{
    //MultiCast Delegate-> return type void
    public delegate void GreetMsg(string msg);//delegates can be defined in namespace level
    //UniCast Delegate-> must be with return type ,only one method can be invoked
    public delegate int Calculation(int num1,int num2);
    class Hindi
    {
        public void WelcomeMsg(string userName)
        {
            System.Console.WriteLine("Suprabhat "+userName); 
        }
    }
    class Tamil
    {
        public void WelcomeMsg(string userName)
        {
            System.Console.WriteLine("Vanakkam " + userName);
        }
    }
    class Marathi
    {
        public void WelcomeMsg(string userName)
        {
            System.Console.WriteLine("Namaskar " + userName);
        }
    }
    class Telugu
    {
        public void WelcomeMsg(string userName)
        {
            System.Console.WriteLine("Namaskaram" + userName);
        }
    }
    public class DelegateDemo
    {
      
        public static void DelegateDemoMain()
        {
            Tamil tObj = new Tamil();
            GreetMsg GreetInTamil = new GreetMsg(tObj.WelcomeMsg);
            GreetInTamil("Devika");
        }
        
    }
}
