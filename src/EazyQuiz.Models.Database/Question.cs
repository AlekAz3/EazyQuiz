using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EazyQuiz.Models.Database;

/// <summary>
/// Описание обьекта вопроса
/// </summary>
[Table("Questions")]
public class Question
{
    /// <summary>
    /// Ид
    /// </summary>
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Тест вопроса
    /// </summary>
    public string? Text { get; set; }
}
