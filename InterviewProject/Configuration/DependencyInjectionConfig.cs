using InterviewProject.Application;
using InterviewProject.Application.Interfaces;
using InterviewProject.Infrastructure;
using InterviewProject.Infrastructure.Interfaces;
using InterviewProject.Infrastructure.Repositories;

namespace InterviewProject.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IInterviewService, InterviewService>();
            services.AddScoped<IInterviewRepository, InterviewRepository>();
        }
    }
}

