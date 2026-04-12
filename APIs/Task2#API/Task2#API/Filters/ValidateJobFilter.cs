using Microsoft.AspNetCore.Mvc.Filters;
using Task2_API.Data;
using Task2_API.Services;
using Microsoft.AspNetCore.Mvc;
using Task2_API.Controllers;
using Task2_API.Filters;
using Task2_API.MiddleWares;
namespace Task2_API.Filters
{
    public class ValidateJobFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var job = context.ActionArguments["jobListing"] as JobListing;
            if(job == null || string.IsNullOrEmpty(job.Title) || string.IsNullOrEmpty(job.Company)
                || job.Salary <= 0)
            {
                context.Result = new BadRequestObjectResult("Invalid job listing data. Title, Company, and Salary are required fields, and Salary must be greater than 0.");
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
