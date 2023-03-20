namespace YouFilms.Models
{
    /// <summary>
    /// Сущность отзыв
    /// </summary>
    public class Review
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Оценка
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Отзыв
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Пользователь оставивший отзыв
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Идентификатор фильма
        /// </summary>
        public int FilmId { get; set; }

        /// <summary>
        /// Фильм на который оставили отзыв
        /// </summary>
        public Film Film { get; set; }
    }
}
