using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using YouFilms.DataLayer;
using YouFilms.Models;

namespace YouFilms.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly GlobalDbContext _globalDB;

        public HomeController(ILogger<HomeController> logger, GlobalDbContext globalDb)
        {
            _logger = logger;
            _globalDB = globalDb;
        }

        public IActionResult Index()
        {
            var r = _globalDB.ContextId;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}