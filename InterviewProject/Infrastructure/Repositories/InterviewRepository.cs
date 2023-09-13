using InterviewProject.Domain.Entities;
using InterviewProject.Infrastructure.Interfaces;

namespace InterviewProject.Infrastructure.Repositories
{
    public class InterviewRepository : IInterviewRepository
    {
        private readonly ILogger<InterviewRepository> _logger;
        private readonly IConfiguration _configuration;

        public InterviewRepository(ILogger<InterviewRepository> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public Candidate GetByName(string name)
        {
            try
            {
                Candidate candidate = new Candidate()
                {
                    Id = 1,
                    Name = "Jefferson Siqueira de Paulo",
                    Approved = true
                };

                return candidate;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}
