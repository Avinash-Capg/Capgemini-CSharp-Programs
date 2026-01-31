using System;
using System.Collections.Generic;
using System.Linq;

namespace LibManagement
{
    class Program
    {
        static List<dynamic> books = new List<dynamic>();

        static void Main(string[] args)
        {
            SeedBooks();

            while (true)
            {
                Console.WriteLine("\n=== BOOK LIBRARY MANAGEMENT SYSTEM ===");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AdminMenu();
                        break;
                    case "2":
                        UserMenu();
                        break;
                    case "3":
                        Console.WriteLine("Thank you! Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        // ========================= Seed Books =========================
        static void SeedBooks()
        {
            books.Add(new { Id = 1, Name = "C# Basics", Publisher = "TechPub", Price = 250.00 });
            books.Add(new { Id = 2, Name = "Java Mastery", Publisher = "CodeHouse", Price = 350.00 });
            books.Add(new { Id = 3, Name = "Python Guide", Publisher = "TechPub", Price = 150.00 });
        }

        // ========================= ADMIN MENU =========================
        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- ADMIN MENU ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Update Book");
                Console.WriteLine("3. Delete Book");
                Console.WriteLine("4. View All Books");
                Console.WriteLine("5. Back");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        UpdateBook();
                        break;
                    case "3":
                        DeleteBook();
                        break;
                    case "4":
                        ViewAllBooks();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void AddBook()
        {
            Console.Write("\nEnter Book ID: ");
            int id = int.Parse(Console.ReadLine());

            if (books.Any(b => b.Id == id))
            {
                Console.WriteLine("Book ID already exists!");
                return;
            }

            Console.Write("Enter Book Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Publisher: ");
            string publisher = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            books.Add(new { Id = id, Name = name, Publisher = publisher, Price = price });

            Console.WriteLine("✅ Book added successfully!");
        }

        static void UpdateBook()
        {
            Console.Write("\nEnter Book ID to Update: ");
            int id = int.Parse(Console.ReadLine());

            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found!");
                return;
            }

            Console.Write("Enter New Book Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter New Publisher: ");
            string publisher = Console.ReadLine();

            Console.Write("Enter New Price: ");
            double price = double.Parse(Console.ReadLine());

            books.Remove(book);
            books.Add(new { Id = id, Name = name, Publisher = publisher, Price = price });

            Console.WriteLine("✅ Book updated successfully!");
        }

        static void DeleteBook()
        {
            Console.Write("\nEnter Book ID to Delete: ");
            int id = int.Parse(Console.ReadLine());

            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Book not found!");
                return;
            }

            books.Remove(book);
            Console.WriteLine("✅ Book deleted successfully!");
        }

        static void ViewAllBooks()
        {
            Console.WriteLine("\n--- ALL BOOKS ---");
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            Console.WriteLine("ID\tName\t\t\tPublisher\tPrice");
            Console.WriteLine("-----------------------------------------------------------");

            foreach (var b in books.OrderBy(b => b.Id))
            {
                Console.WriteLine($"{b.Id}\t{b.Name,-20}\t{b.Publisher,-10}\t{b.Price}");
            }
        }

        // ========================= USER MENU =========================
        static void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("\n--- USER MENU ---");
                Console.WriteLine("1. Browse All Books");
                Console.WriteLine("2. Search Book by Name");
                Console.WriteLine("3. Search Book by Publisher");
                Console.WriteLine("4. View Highest Price Book");
                Console.WriteLine("5. View Lowest Price Book");
                Console.WriteLine("6. Back");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewAllBooks();
                        break;
                    case "2":
                        SearchByName();
                        break;
                    case "3":
                        SearchByPublisher();
                        break;
                    case "4":
                        ShowHighestPriceBook();
                        break;
                    case "5":
                        ShowLowestPriceBook();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void SearchByName()
        {
            Console.Write("\nEnter Book Name to Search: ");
            string search = Console.ReadLine().ToLower();

            var result = books.Where(b => b.Name.ToLower().Contains(search)).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("No matching books found!");
                return;
            }

            Console.WriteLine("\nMatching Books:");
            foreach (var b in result)
            {
                Console.WriteLine($"ID: {b.Id}, Name: {b.Name}, Publisher: {b.Publisher}, Price: {b.Price}");
            }
        }

        static void SearchByPublisher()
        {
            Console.Write("\nEnter Publisher to Search: ");
            string search = Console.ReadLine().ToLower();

            var result = books.Where(b => b.Publisher.ToLower().Contains(search)).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("No matching books found!");
                return;
            }

            Console.WriteLine("\nMatching Books:");
            foreach (var b in result)
            {
                Console.WriteLine($"ID: {b.Id}, Name: {b.Name}, Publisher: {b.Publisher}, Price: {b.Price}");
            }
        }

        static void ShowHighestPriceBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            var maxBook = books.OrderByDescending(b => b.Price).First();

            Console.WriteLine("\n--- HIGHEST PRICED BOOK ---");
            Console.WriteLine($"ID: {maxBook.Id}");
            Console.WriteLine($"Name: {maxBook.Name}");
            Console.WriteLine($"Publisher: {maxBook.Publisher}");
            Console.WriteLine($"Price: {maxBook.Price}");
        }

        static void ShowLowestPriceBook()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            var minBook = books.OrderBy(b => b.Price).First();

            Console.WriteLine("\n--- LOWEST PRICED BOOK ---");
            Console.WriteLine($"ID: {minBook.Id}");
            Console.WriteLine($"Name: {minBook.Name}");
            Console.WriteLine($"Publisher: {minBook.Publisher}");
            Console.WriteLine($"Price: {minBook.Price}");
        }
    }
}