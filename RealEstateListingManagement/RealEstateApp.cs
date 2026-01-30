using System;
using System.Collections.Immutable;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace RealEstateListingManagement;

public class RealEstateApp
{
    private List<IRealEstateListing> listings=new List<IRealEstateListing>();
    public void AddListing(IRealEstateListing realEstateObj)
    {
        listings.Add(realEstateObj);
        System.Console.WriteLine("Added successfully\n");
    }
    public void RemoveListing(int listingID)
    {
        if(listings.Any(item => item.ID == listingID))
        {
            listings.RemoveAll(item => item.ID == listingID);
            System.Console.WriteLine("Removed successfully\n");
        }
        else
        {
            System.Console.WriteLine("ID doesnt exist\n");
        }

    }
    public void UpdateListing(IRealEstateListing realEstateObj)
    {
         var item = listings.FirstOrDefault(x => x.ID == realEstateObj.ID);

        if(item!=null)
        {
           
                item.Title=realEstateObj.Title;
                item.Description=realEstateObj.Description;
                item.Price=realEstateObj.Price;
                item.Location=realEstateObj.Location;

            
            System.Console.WriteLine("Updated Successfully");
        }
        else
        {
            System.Console.WriteLine("ID doesn't exist\n");
        }
    }
    public List<IRealEstateListing> GetListings()
    {
        return listings;
    }
    public List<IRealEstateListing> GetListingsByLocation(string location)
    {
        if (location != null)
        {
            var filteredListings = listings.Where(item => item.Location == location).ToList();
            return filteredListings;
        }
        return new List<IRealEstateListing>();
    }
    public List<IRealEstateListing> GetListingsByPriceRange(int minPrice,int maxPrice)
    {
       return listings
           .Where(item => item.Price >= minPrice && item.Price <= maxPrice)
           .OrderBy(item => item.Price)
           .ToList();
    }
}
