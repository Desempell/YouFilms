using YouFilms.Models.Enum;

namespace YouFilms.Models
{
    /// <summary>
    /// Сущность фильм/сериал
    /// </summary>
    public class Film
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

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

        /// <summary>
        /// Поле для БД
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// Отзывы на фильм
        /// </summary>
        public List<Review> Reviews { get; set; }
    }
}
