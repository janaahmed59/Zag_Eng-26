using Task2_API.Data;

namespace Task2_API.Services
{
    public class JobService : IJobServices
    {
        private readonly ApplicationDbContext _dbContext;
        public JobService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<JobListing> GetAllActive()
        {
            return _dbContext.Set<JobListing>().Where(j => j.IsActive).ToList();
        }
        public JobListing GetById(int id)
        {
            return _dbContext.Set<JobListing>().Find(id);
        }
        public void Create(JobListing job)
        {
            job.Id = 0;
            job.PostedAt = DateTime.UtcNow;
            job.IsActive = true;
            _dbContext.Set<JobListing>().Add(job);
            _dbContext.SaveChanges();
        }
        public void Update(int id, JobListing job)
        {
            var existingJob = _dbContext.Set<JobListing>().Find(id);
            if (existingJob == null) return;
            existingJob.Title = job.Title;
            existingJob.Company = job.Company;
            existingJob.Location = job.Location;
            existingJob.Salary = job.Salary;
            _dbContext.Set<JobListing>().Update(existingJob);
            _dbContext.SaveChanges();
        }
        public void SoftDelete(int id)
        {
            var existingJob = _dbContext.Set<JobListing>().Find(id);
            if (existingJob == null) return;
            existingJob.IsActive = false;
            //_dbContext.Set<JobListing>().Update(existingJob);
            _dbContext.SaveChanges();
        }

    }
}
