using MovieStoreModels.DTO;

namespace MovieStoreDL.DB
{
    internal static class StaticData
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Id = 1, Title = "Tres metros sobre el cielo", Year = 2006
            },
            new Movie
            {
                Id = 2, Title = "Gray", Year = 2015
            },
            new Movie
            {
                Id = 3, Title = "Deadpool", Year = 2024
            }
        };
    }
}
