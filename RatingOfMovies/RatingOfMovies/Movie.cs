namespace RatingOfMovies
{
    public class Movie
    {
        private List<int> ratings = new List<int>();
        public Movie (string title, string releaseYear, string description)
        {
            this.Title = title;
            this.ReleaseYear = releaseYear;
            this.Description = description;
        }

        public string Title { get; private set; }
        public string ReleaseYear { get; private set;}
        public string Description { get; private set; }
        
        public int Result
        {
            get
            {
                return this.ratings.Sum();
            }
        }
        public void AddRating (int rating)
        {
            this.ratings.Add (rating);
        }

    }
}
