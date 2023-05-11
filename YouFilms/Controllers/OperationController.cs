using Microsoft.AspNetCore.Mvc;
using YouFilms.DataLayer;
using YouFilms.Models;

namespace YouFilms.Controllers
{
	public class OperationController : Controller
	{
		public List<Film> Films { get; set; }

		private readonly GlobalDbContext _globalDB;

        public OperationController(GlobalDbContext globalDb)
        {
			_globalDB = globalDb;
		}

        public IActionResult MainPage()
		{
			Films = _globalDB.Films.ToList();
			return View(Films);
		}

	}
}
