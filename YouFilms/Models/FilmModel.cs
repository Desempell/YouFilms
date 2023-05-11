using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YouFilms.DataLayer;

namespace YouFilms.Models
{
    public class FilmModel : PageModel
    {
        public List<Film> Films { get; set; }

        private readonly GlobalDbContext _globalDB;

        public FilmModel(GlobalDbContext globalDb)
        {
            _globalDB = globalDb;
            //FillFilms();
        }

        public void OnGet()
        {
            Films = _globalDB.Films.ToList();
        }

    }
}
