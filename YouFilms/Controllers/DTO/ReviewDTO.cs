namespace YouFilms.Controllers.DTO
{
    public class ReviewDTO
    {
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
    }
}
