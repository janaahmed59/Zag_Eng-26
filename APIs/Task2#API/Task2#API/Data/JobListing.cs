namespace Task2_API.Data
{
    public class JobListing
    {
        public int Id { get; set; }
        public required string Title { get; set; } // Ex: "Backend Developer"
        public required string Company { get; set; } // Ex: "Tech Corp"
        public required string Location { get; set; } // Ex: "Cairo"
        public required decimal Salary { get; set; } // Ex: 15000
        public required bool IsActive { get; set; } // soft delete flag
        public required DateTime PostedAt { get; set; } // auto-set on creation
    }
}
