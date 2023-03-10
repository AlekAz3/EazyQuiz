using System;

namespace EazyQuiz.Models.DTO
{
    /// <summary>
    /// ДТО Возвращаемое сервером после авторизации
    /// </summary>
    public class UserResponse
    {
        /// <summary>
        /// Ид
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Ник
        /// </summary>
        public string? UserName { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public string Gender { get; set; } = string.Empty;

        /// <summary>
        /// Счёт
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string? Country { get; set; }

        /// <summary>
        /// JWT Токен
        /// </summary>
        public string? Token { get; set; }
    }
}
