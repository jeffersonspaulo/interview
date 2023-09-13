using InterviewProject.Application;
using InterviewProject.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace InterviewProject.Controllers
{
    [Route("/v1/[controller]")]
    [ApiController]
    public class InterviewController : Controller
    {
        private readonly IInterviewService _interviewService;

        public InterviewController(IInterviewService interviewService)
        {
            _interviewService = interviewService;
        }

        [HttpGet]
        public ActionResult Get(string name)
        {
            try
            {
                return Ok(_interviewService.GetByName(name));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
