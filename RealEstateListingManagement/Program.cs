using System;
using System.Data;
using System.Transactions;
namespace RealEstateListingManagement;
class Program
{
    static void Menu()
    {
        Console.WriteLine("Real Estate Listing Management");
        Console.WriteLine("==============================");
        System.Console.WriteLine("\n1. Add to list\n2. Remove from list\n3. Update list\n4. Print List\n5. Search list by Location\n6. Search list within price range.\n7. Exit Application.\n");
        System.Console.Write("Enter your choice: ");
    }
    public static void Main()
    {

        try{
                
                List<IRealEstateListing> list= new List<IRealEstateListing>();
              
                
                RealEstateApp appObj=new RealEstateApp();
                do{
                    Menu();
                    int choice=Int32.Parse(Console.ReadLine());
                switch(choice)
                {
                    
                    case(1):
                    {
                        RealEstateListing realestateObj=new RealEstateListing();
                            System.Console.WriteLine("Add details to the list");
                            Console.Write("Enter Id: ");
                            realestateObj.ID=Int32.Parse(Console.ReadLine());

                            Console.Write("Enter Title: ");
                            realestateObj.Title=Console.ReadLine();

                            Console.Write("Enter Description: ");
                            realestateObj.Description=Console.ReadLine();

                            Console.Write("Enter Price: ");
                            realestateObj.Price=Int32.Parse(Console.ReadLine());

                            Console.Write("Enter Location: ");
                            realestateObj.Location=Console.ReadLine();

                            
                            appObj.AddListing(realestateObj);
                            break;
                    }    
                    case(2):{   
                            System.Console.Write("Enter an Id to remove from listings: ");
                            int id=Int32.Parse(Console.ReadLine());
                            appObj.RemoveListing(id);
                            break;
                    }
                    case(3):{
                            RealEstateListing realestateObj=new RealEstateListing();
                            System.Console.Write("Enter id to update: ");
                            int updateId=Int32.Parse(Console.ReadLine());
                            list=appObj.GetListings();
                            foreach(var item in list)
                            {
                                if(list.Any(item=>item.ID==updateId))
                                {
                                
                                    realestateObj.ID=updateId;
                                    System.Console.Write("Enter updated title: ");
                                    realestateObj.Title=Console.ReadLine();

                                    System.Console.Write("Enter updated description: ");
                                    realestateObj.Description=Console.ReadLine();

                                    System.Console.Write("Enter updated price: ");
                                    realestateObj.Price=Int32.Parse(Console.ReadLine());

                                    System.Console.Write("Enter updated location: ");
                                    realestateObj.Location=Console.ReadLine();

                                    appObj.UpdateListing(realestateObj);
                                    


                                }
                            }
                            break;
                    }
                    case(4):{
                    
                            list=appObj.GetListings();
                            foreach(var item in list)
                            {
                                System.Console.WriteLine($"ID: {item.ID}| Title: {item.Title}| Description: {item.Description}| Price: {item.Price} | Location: {item.Location}\n");
                            }
                            break;
                    }
                    case(5):{
                            System.Console.Write("Enter location to search: ");
                            string location=Console.ReadLine();
                            list=appObj.GetListingsByLocation(location);
                            if(list.Count!=0)
                            {
                                foreach(var item in list)
                                {
                                    System.Console.WriteLine($"ID: {item.ID}| Title: {item.Title}| Description: {item.Description}| Price: {item.Price} | Location: {item.Location}\n");
                                }
                            }
                        else
                        {
                            System.Console.WriteLine("Location doesn't exist in the list\n");
                        }
                            break;
                    }
                    case(6):{
                            System.Console.WriteLine("Enter price range to check list within range");
                            System.Console.Write("Enter minimum price: ");
                            int minPrice=Int32.Parse(Console.ReadLine());
                            System.Console.Write("Enter maximum price: ");
                            int maxPrice=Int32.Parse(Console.ReadLine());

                            list=appObj.GetListingsByPriceRange(minPrice,maxPrice);
                            if(list.Count!=0)
                            {
                                foreach(var item in list)
                                {
                                    System.Console.WriteLine($"ID: {item.ID}| Title: {item.Title}| Description: {item.Description}| Price: {item.Price} | Location: {item.Location}\n");
                                }
                            }
                        else
                        {
                            System.Console.WriteLine("List doesn't contain mentioned price range");
                        }
                            break;
                    }
                    case(7):
                        {
                            System.Console.WriteLine("Exiting application");
                            return;
                        }
                default:
                {
                        System.Console.WriteLine("Enter choice between 1 and 6");    
                        break;
                }
                }
                }while(true);
                



                    
        }catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }


        
    }
}