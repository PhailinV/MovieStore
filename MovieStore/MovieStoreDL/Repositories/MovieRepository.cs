using MovieStoreDL.DB;
using MovieStoreDL.Interfaces;
using MovieStoreModels.DTO;

namespace MovieStoreDL.Repositories
{
    public class MovieRepository : IMovieRepository

    {
        public List<Movie> GetMovies()
        {
            return StaticData.Movies;
        }
    }
}
