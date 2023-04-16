using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterView.Domain.Entities;

public class Answer : EntityBase
{
    [Required] 
    public Guid AnswerId { get; set; }

    [Required]
    [Display(Name = "Текст ответа")]
    public string Text { get; set; }

    //Навигационные свойства EntityFramework
    [ForeignKey("QuestionId")]
    public Guid QuestionId { get; set; }

    public Question Question { get; set; }
}
