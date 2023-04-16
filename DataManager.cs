using InterView.Domain.Repository.Abstractions;

namespace InterView.Domain;

public class DataManager
{
    public IInterviewsRepository InterviewsRepository;
    public IQuestionsRepository QuestionsRepository;
    public IAnswersRepository AnswersRepository;

    public DataManager(IInterviewsRepository interviewsRepository, IQuestionsRepository questionsRepository, IAnswersRepository answersRepository)
    {
        InterviewsRepository = interviewsRepository;
        QuestionsRepository = questionsRepository;
        AnswersRepository = answersRepository;
    }
}
