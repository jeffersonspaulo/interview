using InterviewProject.Application.Interfaces;
using InterviewProject.Domain.Entities;
using InterviewProject.Infrastructure.Interfaces;

namespace InterviewProject.Application
{
    public class InterviewService : IInterviewService
    {
        private readonly ILogger<InterviewService> _logger;
        private readonly IInterviewRepository _interviewRepository;

        public InterviewService(ILogger<InterviewService> logger, IInterviewRepository interviewRepository)
        {
            _logger = logger;
            _interviewRepository = interviewRepository;
        }

        public Candidate GetByName(string name)
        {
            try
            {
                //Do something with business logic

                return _interviewRepository.GetByName(name);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
