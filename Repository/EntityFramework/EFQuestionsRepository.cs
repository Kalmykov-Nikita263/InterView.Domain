using InterView.Domain.Entities;
using InterView.Domain.Repository.Abstractions;
using System;
using System.Linq;

namespace InterView.Domain.Repository.EntityFramework;

public class EFQuestionsRepository : IQuestionsRepository
{
    private readonly ApplicationDbContext _context;

    public EFQuestionsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void DeleteQuestion(Guid questionId)
    {
        _context.Questions.Remove(new Question { QuestionId = questionId });
        _context.SaveChanges();
    }

    public Question GetQuestionById(Guid questionId)
    {
        return _context.Questions.FirstOrDefault(x => x.QuestionId == questionId);
    }

    public IQueryable<Question> GetQuestions()
    {
        return _context.Questions;
    }

    public void SaveQuestion(Question question)
    {
        if (question.QuestionId == default)
            _context.Entry(question).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        else
            _context.Entry(question).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        _context.SaveChanges();
    }
}
