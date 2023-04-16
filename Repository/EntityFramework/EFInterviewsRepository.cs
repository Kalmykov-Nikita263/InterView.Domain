using InterView.Domain.Entities;
using InterView.Domain.Repository.Abstractions;
using System;
using System.Linq;

namespace InterView.Domain.Repository.EntityFramework;

public class EFInterviewsRepository : IInterviewsRepository
{
    private readonly ApplicationDbContext _context;

    public EFInterviewsRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void DeleteInterview(Guid interviewId)
    {
        _context.Interviews.Remove(new Interview { InterviewId = interviewId });
        _context.SaveChanges();
    }

    public Interview GetInterviewById(Guid interviewId)
    {
        return _context.Interviews.FirstOrDefault(x => x.InterviewId == interviewId);
    }

    public IQueryable<Interview> GetInterviews()
    {
        return _context.Interviews;
    }

    public void SaveInterview(Interview interview)
    {
        if (interview.InterviewId == default)
            _context.Entry(interview).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        else
            _context.Entry(interview).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

        _context.SaveChanges();
    }
}
