using InterView.Domain.Entities;
using InterView.Domain.Repository.Abstractions;
using System;
using System.Linq;

namespace InterView.Domain.Repository.EntityFramework;

public class EFAnswersRepository : IAnswersRepository
{
    private readonly ApplicationDbContext _context;

    public EFAnswersRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void DeleteAnswer(Guid answerId)
    {
        _context.Answers.Remove(new Answer { AnswerId = answerId });
        _context.SaveChanges();
    }

    public Answer GetAnswerById(Guid answerId)
    {
        return _context.Answers.FirstOrDefault(x => x.AnswerId == answerId);
    }

    public IQueryable<Answer> GetAnswers()
    {
        return _context.Answers;
    }

    public void SaveAnswer(Answer answer)
    {
        if (answer.AnswerId == default)
            _context.Entry(answer).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        else
            _context.Entry(answer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        _context.SaveChanges();
    }
}
