using InterviewProject.Domain.Entities;

namespace InterviewProject.Infrastructure.Interfaces
{
    public interface IInterviewRepository
    {
        Candidate GetByName(string name);
    }
}
