using System.ComponentModel;
using System.Linq;
namespace MovieStock;
class Program
{
    public static List<Movie> MovieList=new List<Movie>()
    {
        new Movie{Title="Jailer",Artist="Rajinikanth",Genre="Action",Ratings=9},
        new Movie{Title="Leo",Artist="Vijay",Genre="Action",Ratings=8},
        new Movie{Title="Premam",Artist="NivinPauly",Genre="Romance",Ratings=9},
        new Movie{Title="Bangalore Days",Artist="Dulquer Salmaan",Genre="Drama",Ratings=8},
        new Movie{Title="Drishyam",Artist="Mohanlal",Genre="Thriller",Ratings=10},
        new Movie{Title="Kumbalangi Nights",Artist="Fahadh Faasil",Genre="Drama",Ratings=9},
    };
    public void AddMovie(string MovieDetails)
    {
        Movie movieObj=new Movie();
        string[] movieDetails=MovieDetails.Split(",");
     
        movieObj.Title=movieDetails[0];
        movieObj.Artist=movieDetails[1];
        movieObj.Genre=movieDetails[2];
        movieObj.Ratings=Int32.Parse(movieDetails[3]);
        
      
        MovieList.Add(movieObj);

    } 
    public List<Movie> ViewMoviesByGenre(string genre)
    {
        List<Movie> genreList=new List<Movie>();
        foreach(var item in MovieList)
        {
            if(item.Genre.Equals(genre,StringComparison.OrdinalIgnoreCase))
            {
                genreList.Add(item);
            }
        }
        return genreList;
    }
    public List<Movie> ViewMoviesByRatings()
    {
        return MovieList.OrderBy(x=>x.Ratings).ToList();
    }
    public static void Main()
    {
        try{
        System.Console.Write("Enter Movie Details: ");
        string movieDetails=Console.ReadLine();
        Program pObj=new Program();
        pObj.AddMovie(movieDetails);
        System.Console.WriteLine("Movie List after adding");
        System.Console.WriteLine("=======================");
        Console.ForegroundColor=ConsoleColor.Green;
        foreach (Movie m in MovieList)
        {
            Console.WriteLine($"{m.Title} | {m.Artist} | {m.Genre} | {m.Ratings}");
        }
        Console.ForegroundColor=ConsoleColor.White;
        System.Console.Write("\nEnter genre: ");
        
        string genre=Console.ReadLine();
        var movieGenreList=pObj.ViewMoviesByGenre(genre);
        if(movieGenreList.Count==0)
        {
            System.Console.WriteLine($"No movies found in genre: {genre}");
        }
        else
        {
            System.Console.WriteLine("=============================");
            Console.ForegroundColor=ConsoleColor.Green;
            foreach(var item in movieGenreList)
            {
                System.Console.WriteLine($"Title : {item.Title}|, Artist: {item.Artist}|, Genre: {item.Genre}|, Ratings: {item.Ratings}");
            }
            Console.ForegroundColor=ConsoleColor.White;
        }
        System.Console.WriteLine("\nMovies According to their Ratings");
        
        var ratingList=pObj.ViewMoviesByRatings();
        if(ratingList.Count==0)
        {
            System.Console.WriteLine("The movie list is empty");
        }
        else
        {
            System.Console.WriteLine("====================================");
            Console.ForegroundColor=ConsoleColor.Green;
            foreach(var item in ratingList)
            {
                System.Console.WriteLine($"Title : {item.Title}|, Artist: {item.Artist}|, Genre: {item.Genre}|, Ratings: {item.Ratings}");
            }
            Console.ForegroundColor=ConsoleColor.White;
        }
        }
        catch(Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}