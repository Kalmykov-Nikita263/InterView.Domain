using InterView.Domain.Entities;
using System;
using System.Linq;

namespace InterView.Domain.Repository.Abstractions;

public interface IInterviewsRepository
{
    IQueryable<Interview> GetInterviews();

    Interview GetInterviewById(Guid interviewId);

    void SaveInterview(Interview interview);

    void DeleteInterview(Guid interviewId);
}
