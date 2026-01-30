using System;
namespace UserAuthentication;
class Program
{
    public static void Main()
    {
        try{
            User userObj=new User();
            System.Console.Write("Enter User Name: ");
            userObj.Name=Console.ReadLine();

            System.Console.Write("Enter User Password: ");
            userObj.Password=Console.ReadLine();

            System.Console.Write("Enter Confirmation Password: ");
            userObj.ConfirmationPassword=Console.ReadLine();
            Program pObj=new Program();
            var result=pObj.ValidatePassword(userObj.Name,userObj.Password,userObj.ConfirmationPassword);
            

        }
        catch(PasswordMismatchException e)
        {
            System.Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }

    }
    public User ValidatePassword(string name,string password,string confirmationPassword)
    {
        User userObj=new User();
        if(password==confirmationPassword)
        {
            userObj.Name=name;
            userObj.Password=password;
            userObj.ConfirmationPassword=confirmationPassword;

        }
        else
        {
            throw new PasswordMismatchException();
        }
        return userObj;
    }
}
public class PasswordMismatchException : Exception
{
    public PasswordMismatchException():base("Password entered does not match")
    {
        
    }
     public PasswordMismatchException(string message):base()
    {
        
    }
}