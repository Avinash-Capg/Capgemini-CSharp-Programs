// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;
namespace MovieLibrary;
class Program
{
    static void Menu()
    {
        System.Console.WriteLine("          MOVIE LIBRARY          ");
        System.Console.WriteLine("===================================");
        System.Console.WriteLine("1. Add Film");
        System.Console.WriteLine("2. Remove Film");
        System.Console.WriteLine("3. View All Films");
        System.Console.WriteLine("4. Search Films");
        System.Console.WriteLine("5. Get Total Film Count");
        System.Console.WriteLine("6. Exit\n");


    }
    static void Main(String[] args)
    {
        FilmLibrary libraryObj = new FilmLibrary();
        do
        {
            Menu();
            System.Console.Write("Enter your option: ");
            int option=Int32.Parse(Console.ReadLine());
           
            switch(option)
            {
                case 1:
                    {
                        
                        

                        Film filmObj=new Film();
                        System.Console.WriteLine("Enter details to add to the list");
                        System.Console.Write("Enter Movie Title: ");
                        filmObj.Title=Console.ReadLine();
                        System.Console.Write("Enter Movie Director: ");
                        filmObj.Director=Console.ReadLine();
                        System.Console.Write("Enter Year: ");
                        filmObj.Year=Int32.Parse(Console.ReadLine());

                        bool result=libraryObj.AddFilm(filmObj);
                        if(result)
                        {
                            System.Console.WriteLine("Film added Successfully!");
                        }
                        else
                        {
                            System.Console.WriteLine("Film Already exists or Invalid Input.");
                        }
                        


                        break;
                    }
                case 2:
                    {
                        System.Console.WriteLine("Enter details to remove from the list");
                        System.Console.Write("Enter Title: ");
                        string titleInput=Console.ReadLine();
                        bool result=libraryObj.RemoveFilm(titleInput);
                        if(result)
                        {
                            System.Console.WriteLine("Film removed successfully!");
                        }
                        else
                        {
                            System.Console.WriteLine("Film not found.");
                        }

                        break;
                    }
                case 3:
                    {
                        System.Console.WriteLine("Film List");
                        List<IFilm> films=libraryObj.GetFilms();
                        if(films.Count==0)
                        {
                            System.Console.WriteLine("Empty list.");
                        }
                        else{
                            foreach(IFilm film in films)
                            {
                                System.Console.WriteLine($"{film.Title} | {film.Director} | {film.Year} |");
                            }
                        }
                        break;

                    }
                case 4:
                    {
                        System.Console.Write("Enter query to search: ");
                        string query=Console.ReadLine();
                        List<IFilm> films=libraryObj.SearchFilms(query);
                        if(films.Count==0)
                        {
                            System.Console.WriteLine("No movie found with the input query.");
                        }
                        else
                        {
                            foreach(IFilm film in films)
                            {
                                System.Console.WriteLine($"{film.Title} | {film.Director} | {film.Year} |");
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        System.Console.Write($"Total film Count: {libraryObj.GetTotalFilmCount()}\n");
                        break;
                    }
                case 6:
                    {
                        System.Console.WriteLine("Exiting Movie Library. GoodBye!");
                        return;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid option choose between 1 and 6.");
                        break;
                    }
            }
        }while(true);
    }
}