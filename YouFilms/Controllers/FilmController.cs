using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YouFilms.Controllers.DTO;
using YouFilms.DataLayer;
using YouFilms.Models;

namespace YouFilms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly GlobalDbContext _globalDB;
        private readonly ILogger<FilmController> _logger;

        public FilmController(ILogger<FilmController> logger, GlobalDbContext globalDb)
        {
            _logger = logger;
            _globalDB = globalDb;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Film> Create([FromBody] FilmDTO filmDTO)
        {
            var film = new Film()
            {
                Name = filmDTO.Name,
                Genres = filmDTO.Genres,
                Poster = filmDTO.Poster,
                YearOfRelease = filmDTO.YearOfRelease,
                Country = filmDTO.Country,
                MPAA = filmDTO.MPAA,
                TimeDuration = filmDTO.TimeDuration,
                Description = filmDTO.Description,
                Director = filmDTO.Director,
                AverageRating = filmDTO.AverageRating,
                EntityType = filmDTO.EntityType
            };

            _globalDB.Add(film);
            _globalDB.SaveChanges();

            return film;
        }

        [HttpGet("{id?}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Film> Get(int id)
            => _globalDB.Films.FirstOrDefault(x => x.Id == id);
    }
}
