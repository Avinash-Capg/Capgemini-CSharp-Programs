using System;

namespace MovieLibrary;

public interface IFilmLibrary
{
    bool AddFilm(IFilm film);
    bool RemoveFilm(string title);
    List<IFilm> GetFilms();
    List<IFilm> SearchFilms(string query);
    int GetTotalFilmCount();


}
