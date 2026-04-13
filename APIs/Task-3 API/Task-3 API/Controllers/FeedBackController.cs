using Microsoft.AspNetCore.Mvc;
using Task_3_API.Data;
using Microsoft.AspNetCore.Mvc.Authorization;
namespace Task_3_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedBackController : ControllerBase
    {
        //public IFeedbackService _feedbackService;
        private readonly IConfiguration configuration;
        private readonly ILogger<FeedBackController> logger;
        public FeedBackController(IConfiguration Config, ILogger<FeedBackController> Logger)
        {
            configuration = Config;
            logger = Logger;
        }

        [HttpPost]
        [Route("info")]
        public IActionResult CreateFeedback([FromBody] FeedbackRequest requestBody, [FromQuery] int rate)
        {
            var Name = configuration["SystemSettings:SystemName"];
            var IsAnonymous = configuration.GetValue<bool>("SystemSettings:AllowAnonymousFeedback");
            logger.LogInformation($"Recived regust from{requestBody.UserName}");
            if(rate < 3)
            {
                logger.LogWarning($"User {requestBody.UserName} is not satisfied with the service ant the Rate :{rate}");
            }
            return Ok($"Feedback received for {Name}, Thank you, {requestBody.UserName}!");
        }
     
    }
}
