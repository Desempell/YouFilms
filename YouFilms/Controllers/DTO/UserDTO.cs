namespace YouFilms.Controllers.DTO
{
	public class UserDTO
	{
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
	}
}
