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
	public class UserController : ControllerBase
	{
		private readonly GlobalDbContext _globalDB;
		private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, GlobalDbContext globalDb)
        {
			_logger = logger;
			_globalDB = globalDb;
		}

		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<User> Create([FromBody] UserDTO userDTO)
		{
			using var md5 = MD5.Create();
			var user = new User()
			{
				Login = userDTO.Login,
				Password = HashService.GetMd5Hash(md5, userDTO.Password),
				Avatar = userDTO.Avatar,
				PhoneNumber = userDTO.PhoneNumber,
				FavorGenre = userDTO.FavorGenre,
				IsAdministrator = userDTO.IsAdministrator
			};

			_globalDB.Add(user);
			_globalDB.SaveChanges();

			return user;
		}

		[HttpGet("{id?}")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public ActionResult<User> Get(int id)
			=> _globalDB.Users.FirstOrDefault(x => x.Id == id);
	}
}
