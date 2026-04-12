using Microsoft.AspNetCore.Mvc;
using Task2_API.Data;
using Task2_API.Services;
using Task2_API.Filters;

namespace Task2_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobListingsController : Controller
    {
        private readonly IJobServices _service;
        public JobListingsController(IJobServices Services)
        {
            _service = Services;
        }
        [HttpGet]
        [Route("")]
        public IActionResult GetAllActiveJobs()
        {
            var jobListings = _service.GetAllActive().ToList();
            return Ok(jobListings); // 200
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetJobById(int id)
        {
            var jobListing = _service.GetById(id);
            return jobListing == null ? NotFound() : Ok(jobListing);
        }
        [HttpPost]
        [Route("")]
        [ServiceFilter(typeof(ValidateJobFilter))]
        public IActionResult CreateJob(JobListing jobListing)
        {
            _service.Create(jobListing);
            return Ok(jobListing.Id);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpPut]
        [Route("")]
        [ServiceFilter(typeof(ValidateJobFilter))]
        public IActionResult UpdateJob(int id, JobListing jobListing)
        {
             _service.Update(id, jobListing);
            return Ok(jobListing.Id);
        }

        [HttpDelete]
        [Route("")]
        public IActionResult DeleteJob(int id)
        {
           _service.SoftDelete(id);
            return Ok();
        }
    }
}
