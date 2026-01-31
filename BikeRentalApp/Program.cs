using System;
using System.Collections.Generic;

public class Bike
{
    public string Model { get; set; }
    public int PricePerDay { get; set; }
    public string Brand { get; set; }
}

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count + 1;
        Program.bikeDetails.Add(key, new Bike { Model = model, Brand = brand, PricePerDay = pricePerDay });
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> grouped = new SortedDictionary<string, List<Bike>>();

        foreach (var item in Program.bikeDetails)
        {
            Bike bike = item.Value;

            if (!grouped.ContainsKey(bike.Brand))
                grouped[bike.Brand] = new List<Bike>();

            grouped[bike.Brand].Add(bike);
        }

        return grouped;
    }
}

public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    public static void Main(string[] args)
    {
        BikeUtility util = new BikeUtility();

        while (true)
        {
            Console.WriteLine("\n1. Add Bike Details\n2. Group Bikes By Brand\n3. Exit\n");
            Console.Write("Enter your choice ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("\nEnter the model: ");
                string model = Console.ReadLine();

                Console.Write("\nEnter the brand: ");
                string brand = Console.ReadLine();

                Console.Write("\nEnter the price per day: ");
                int price = int.Parse(Console.ReadLine());

                util.AddBikeDetails(model, brand, price);
                Console.WriteLine("\nBike details added successfully\n");
            }
            else if (choice == 2)
            {
                var grouped = util.GroupBikesByBrand();
                Console.WriteLine();

                foreach (var g in grouped)
                {
                    foreach (var bike in g.Value)
                    {
                        Console.WriteLine(g.Key + " " + bike.Model);
                    }
                }

                Console.WriteLine();
            }
            else if (choice == 3)
            {
                break;
            }
        }
    }
}