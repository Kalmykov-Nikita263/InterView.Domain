using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InterView.Domain.Entities;

public class Question : EntityBase
{
    [Required]
    public Guid QuestionId { get; set; }

    [Required]
    [Display(Name = "Текст вопроса")]
    public string Text { get; set; }

    public Guid InterviewId { get; set; }

    //Навигационные свойства для EntityFramework
    [ForeignKey("InterviewId")]
    public Interview Interview { get; set; }

    public List<Answer> Answers { get; set; }
}
