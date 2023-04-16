using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterView.Domain.Entities;

public class Interview : EntityBase
{
    [Required]
    public Guid InterviewId { get; set; }

    [Required(ErrorMessage = "Заполните название интервью")]
    [Display(Name = "Название интервью")]
    public string Title { get; set; }

    [Display(Name = "Дата начала интервью")]
    public DateTime StartDate { get; set; }

    [Display(Name = "Дата окончания интервью")]
    public DateTime EndDate { get; set; }

    //Навигационное свойство для EntityFramework
    public List<Question> Questions { get; set; }
}
