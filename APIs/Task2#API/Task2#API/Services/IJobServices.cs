using Task2_API.Data;

namespace Task2_API.Services
{
    public interface IJobServices
    {
        IEnumerable<JobListing> GetAllActive();
        JobListing GetById(int id);
        void Create(JobListing job);
        void Update(int id, JobListing job);
        void SoftDelete(int id);
    }
}
