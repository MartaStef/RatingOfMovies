using RatingOfMovies;

Movie movie1 = new Movie("Interstellar", "2014", "space");
Movie movie2 = new Movie("I,Robot", "2004", "robot");
Movie movie3 = new Movie("WALL.E", "2008", "robot");
Movie movie4 = new Movie("Matrix", "1999", "simulation");

List<Movie> movies = new List<Movie>()
{ movie1, movie2, movie3, movie4 };

foreach (var movie in movies)
{
    while (true)
    {
        Console.WriteLine("Podaj ocenę filmu:" + movie.Title);
        var input = Console.ReadLine();
        if (input == "next")
        { break; }
        var rating = int.Parse(input);
        movie.AddRating(rating);
    }
}

int maxResult = 0;

Movie bestMovie = null;

foreach (var movie in movies)
{
    if (movie.Result > maxResult)
    {
        bestMovie = movie;
        maxResult = movie.Result;
    }
}

Console.WriteLine($"Najlepszy film pod tytułem: " + bestMovie.Title + " z " + bestMovie.ReleaseYear +
    " roku otrzymał" + bestMovie.Result + " punktów");