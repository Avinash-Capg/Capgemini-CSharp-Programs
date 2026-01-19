using System;
namespace PhoneCallSubscription;
class Pprogram
{
    public static void Main()
    {
        PhoneCall callObj=new PhoneCall();
        System.Console.Write("MakeAPhoneCall(true/false): ");
        bool phoneCall=Boolean.Parse(Console.ReadLine());
        callObj.MakeAPhoneCall(phoneCall);
        System.Console.WriteLine(callObj.Message);
    }
}