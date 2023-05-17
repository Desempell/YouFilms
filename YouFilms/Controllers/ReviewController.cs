using Microsoft.AspNetCore.Mvc;
using YouFilms.Controllers.DTO;
using YouFilms.DataLayer;
using YouFilms.Models;
using System.Security.Cryptography;
using NuGet.Common;
using System.Text;
using YouFilms.Controllers.Helpers;

namespace YouFilms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly GlobalDbContext _globalDB;
        private readonly ILogger<ReviewController> _logger;

        public ReviewController(ILogger<ReviewController> logger, GlobalDbContext globalDb)
        {
            _logger = logger;
            _globalDB = globalDb;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Review> Create([FromBody] ReviewDTO reviewDTO)
        {
            var review = new Review()
            {
                Title = reviewDTO.Title,
                Rating = reviewDTO.Rating,
                Description = reviewDTO.Description,
            };

            _globalDB.Add(review);
            _globalDB.SaveChanges();

            return review;
        }
        [HttpGet("{id?}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Review> Get(int id)
            => _globalDB.Reviews.FirstOrDefault(x => x.Id == id);
    }
}
