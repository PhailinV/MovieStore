using MovieStoreModels.DTO;

namespace MovieStoreDL.Interfaces
{
    internal interface IMovieRepository
    {
        List<Movie> GetMovies();
    }
}
