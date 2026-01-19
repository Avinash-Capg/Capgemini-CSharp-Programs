using System;

namespace MovieLibrary;

public class FilmLibrary:IFilmLibrary
{
    private List<IFilm> _films=null;
    public FilmLibrary()
    {
        _films=new List<IFilm>()
        {
            new Film()
            {
                Title="Inception",Director="Christopher Nolan",Year=2010
            },
            new Film()
            {
                Title="Titanic",Director="James Cameron",Year=1997
            }
        };
        
    }
   
    public bool AddFilm(IFilm film)
    {
       if(film==null)
        {
            return false;
        }
        IFilm exists=_films.Find(s=>s.Title.Equals(film.Title,StringComparison.OrdinalIgnoreCase));
        if(exists!=null)
        {
            return false;
        }
        _films.Add(film);
        return true;
    } 
     public bool RemoveFilm(string title)
    {
       
        if(title==null)
        {
           return false;
        }
         IFilm filmObj=_films.Find(s=>s.Title.Equals(title,StringComparison.OrdinalIgnoreCase));
        if(filmObj==null)
        {
            return false;
        }
        _films.Remove(filmObj);
        return true;
    
    } 
    public List<IFilm> GetFilms()
    {
        return new List<IFilm>(_films);
    }

    public List<IFilm> SearchFilms(string query)
    {
        List<IFilm> result=new List<IFilm>();
        if(query==null)
        {
           return result;
        }
         foreach(IFilm film in _films)
            {
                if((film.Title.Contains(query,StringComparison.OrdinalIgnoreCase))||(film.Director.Contains(query,StringComparison.OrdinalIgnoreCase)))
                {
                    result.Add(film);
                }
            }
        return result;
    }
    public int GetTotalFilmCount()
    {
        return _films.Count;
    }
}
