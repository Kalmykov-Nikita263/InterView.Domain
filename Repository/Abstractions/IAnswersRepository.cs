using InterView.Domain.Entities;
using System;
using System.Linq;

namespace InterView.Domain.Repository.Abstractions;

public interface IAnswersRepository
{
    IQueryable<Answer> GetAnswers();

    Answer GetAnswerById(Guid answerId);

    void SaveAnswer(Answer answer);

    void DeleteAnswer(Guid answerId);
}
