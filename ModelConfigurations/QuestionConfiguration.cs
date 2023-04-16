using InterView.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace InterView.Domain.ModelConfigurations;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasData(
            new Question
            {
                QuestionId = new Guid("9f52e4cc-1fdd-4e68-bd08-e619929d7b4f"),
                Text = "Как вы начали свою карьеру в киноиндустрии и какие были ваши первые работы?",
                InterviewId = new Guid("607ed998-da08-11ed-afa1-0242ac120002")
            },
            new Question
            {
                QuestionId= new Guid("b9edad52-a404-4d8b-96d1-190dd8aa054a"),
                Text = "Какие фильмы или режиссеры оказали влияние на ваше творчество?",
                InterviewId = new Guid("607ed998-da08-11ed-afa1-0242ac120002")
            },
            new Question
            {
                QuestionId = new Guid("598f908c-c02d-4e1b-904f-1da660c3bccd"),
                Text = "Как вы выбираете проекты, над которыми хотите работать?",
                InterviewId = new Guid("607ed998-da08-11ed-afa1-0242ac120002")
            }
        );
    }
}
