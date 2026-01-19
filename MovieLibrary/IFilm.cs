using System;

namespace MovieLibrary;

public interface IFilm
{
    public string Title{ get; set; }
    public string Director{ get; set; }
    public int Year { get; set; }
}
