using Microsoft.AspNetCore.Mvc;
using MovieStoreModels.DTO;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly <MoviesController>;

        private readonly IMovieRepository _movieRepository;
        public MoviesController(
            IMovieRepository MovieRepository)
        {
            _movieRepository = MovieRepository;
        }

        [HttpGet] //������� ����� � ��������
        public IEnumerable<Movie> Get()
        {
            return _movieRepository.GetMovies();
        }
    }
}
