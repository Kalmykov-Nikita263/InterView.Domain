using System.Linq;
using System;
using InterView.Domain.Entities;

namespace InterView.Domain.Repository.Abstractions;

public interface IQuestionsRepository
{
    IQueryable<Question> GetQuestions();

    Question GetQuestionById(Guid questionId);

    void SaveQuestion(Question question);

    void DeleteQuestion(Guid questionId);
}
