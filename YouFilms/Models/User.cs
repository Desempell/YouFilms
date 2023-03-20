namespace YouFilms.Models
{
    /// <summary>
    /// Сущность пользователь
    /// </summary>
    public class User
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Путь к файлу с аватаром (?)
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>

        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Любимый жанр
        /// </summary>
        public string? FavorGenre { get; set; }

        /// <summary>
        /// Проверка на права администратора
        /// </summary>
        public bool IsAdministrator { get; set; }

        /// <summary>
        /// Любимые фильмы
        /// </summary>
        public List<Film> FavorFilms { get; set; }

        /// <summary>
        /// Оставленные отзывы
        /// </summary>
        public List<Review> Reviews { get; set; }
    }
}
