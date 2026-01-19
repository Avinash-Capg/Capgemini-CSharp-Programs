using System;
namespace ConstructionEstimate;
class Program
{
    public static void Main()
    {
        try
        {
            EstimateDetails estimateObj=new EstimateDetails();

            System.Console.Write("Enter Construction Area: ");
            estimateObj.ConstructionArea=Convert.ToSingle(Console.ReadLine());

            System.Console.Write("Enter Site Area: ");
            estimateObj.SiteArea=Convert.ToSingle(Console.ReadLine());
            Program pObj=new Program();
            var testObj=pObj.ValidateConstructionEstimate( estimateObj.ConstructionArea,estimateObj.SiteArea);
            if(testObj!=null)
            {
                System.Console.WriteLine("Construction estimate is approved");
            }

            

        }
        catch(ConstructionEstimateException ex)
        {
            System.Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
        }
    }
    public EstimateDetails ValidateConstructionEstimate(float constructionArea,float siteArea)
    {
        EstimateDetails validateObj=new EstimateDetails();
        if(constructionArea<siteArea)
        {
            validateObj.ConstructionArea=constructionArea;
            validateObj.SiteArea=siteArea;
        }
        else if(constructionArea>siteArea)
        {
            throw new ConstructionEstimateException();
        }
        return validateObj;
    }
}
public class ConstructionEstimateException: Exception
{
    public ConstructionEstimateException():base()
    {
        System.Console.WriteLine("Sorry your Construction Estimate is not approved");
    }
    public ConstructionEstimateException(string message):base(message)
    {
        System.Console.WriteLine(message);
    }
}