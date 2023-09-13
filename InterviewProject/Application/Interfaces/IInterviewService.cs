using InterviewProject.Domain.Entities;

namespace InterviewProject.Application.Interfaces
{
    public interface IInterviewService
    {
        Candidate GetByName(string name);
    }
}
