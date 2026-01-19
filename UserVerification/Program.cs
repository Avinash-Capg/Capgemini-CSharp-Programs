using System;
using System.Linq;
namespace UserVerification;
class Program
{
    public static void Main()
    {
        try
        {
            User userObj=new User();
            System.Console.Write("Enter Name: ");
            userObj.Name=Console.ReadLine();

            System.Console.Write("Enter Phone Number: ");
            userObj.PhoneNumber=Console.ReadLine();

            Program programObj=new Program();
            var q1=programObj.ValidatePhoneNumber(userObj.Name,userObj.PhoneNumber);
            if(q1!=null)
            {
                System.Console.WriteLine("User data created successfully");
            }

        }
        catch(InvalidPhoneNumberException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }

    }
    public User ValidatePhoneNumber(string name,string phoneNumber)
    {
        User validateObj=new User();
        
        if(phoneNumber.Length==10)
        {
           bool isDigit=phoneNumber.All(char.IsDigit);
           if(isDigit)
            {
                validateObj.Name=name;
                validateObj.PhoneNumber=phoneNumber;
            }
            else
            {
                throw new InvalidPhoneNumberException();
            }
           
        }
        else
        {
            throw new InvalidPhoneNumberException();
        }
        return validateObj;
    }
}
public class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException():base()
    {
        System.Console.WriteLine("Invalid phone number");
    }
    public InvalidPhoneNumberException(string message):base(message)
    {
        System.Console.WriteLine(message);
    }
}