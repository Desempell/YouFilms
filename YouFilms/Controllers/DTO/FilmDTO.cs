using YouFilms.Models.Enum;

namespace YouFilms.Controllers.DTO
{
    public class FilmDTO
    {
        /// <summary>
        /// Название фильма
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Жанры
        /// </summary>
        public List<string> Genres { get; set; }

        /// <summary>
        /// Постер
        /// </summary>
        public string Poster { get; set; }

        /// <summary>
        /// Год выпуска
        /// </summary>
        public int YearOfRelease { get; set; }

        /// <summary>
        /// Страна 
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// Возрастные ограничения
        /// </summary>
        public string? MPAA { get; set; }

        /// <summary>
        /// Продолжительность фильма
        /// </summary>
        public int TimeDuration { get; set; }

        /// <summary>
        /// Описание 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Режиссер 
        /// </summary>
        public string Director { get; set; }

        /// <summary>
        /// Средняя оценка 
        /// </summary>
        public double AverageRating { get; set; }

        public EntityType EntityType { get; set; }
    }
}
