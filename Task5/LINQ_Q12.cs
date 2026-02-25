using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LINQ_Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>
            {
                new Employee { Name = "Ali", Department = "Engineering", Salary = 9000m },
                new Employee { Name = "Sara", Department = "Engineering", Salary = 8500m },
                new Employee { Name = "Omar", Department = "HR", Salary = 6000m },
                new Employee { Name = "Mona", Department = "HR", Salary = 6200m },
                new Employee { Name = "Yara", Department = "Marketing", Salary = 7000m },
                new Employee { Name = "Karim", Department = "Marketing", Salary = 7500m },
                new Employee { Name = "Nada", Department = "Engineering", Salary = 9500m },
            };
            List<Course> courses = new List<Course>
            {
                new Course { Title = "C# Basics", Students = new List<string> { "Ali", "Sara", "Omar" } },
                new Course { Title = "LINQ Mastery", Students = new List<string> { "Sara", "Mona", "Ali" } },
                new Course { Title = "ASP.NET Core", Students = new List<string> { "Yara", "Omar", "Karim" } }
            };
            Console.WriteLine("1. From employees: get the TOP 2 highest - paid employees per department.");
            var topPaidEmployees = Employees
                .GroupBy(e => e.Department)
                .SelectMany(g => g.OrderByDescending(e => e.Salary).Take(2));

            foreach (var item in topPaidEmployees)
            {
                   Console.WriteLine($"{item.Name} - {item.Department} - {item.Salary}");
            }

            Console.WriteLine("2.From courses: build a Dictionary<string, int> of CourseName → StudentCount }, but only for courses with > 2 students.");
            var courseStudentCount = courses
                .Where(c => c.Students.Count > 2)
                .ToDictionary(c => c.Title, c => c.Students.Count);

            foreach (var item in courseStudentCount)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("3.Check: ");
            var anyLowPaidInEngineering = Employees
                .Where(e => e.Department == "Engineering")
                .Any(e => e.Salary < 8000);

            Console.WriteLine($"Any employee in Engineering earn less than 8000 ?01 {anyLowPaidInEngineering}");
           // another way
            var anyLowPaidInEngineering2 = Employees
                .Any(e => e.Department == "Engineering" && e.Salary < 8000);
            
            Console.WriteLine($"Any employee in Engineering earn less than 8000 ?02 {anyLowPaidInEngineering2}");
            
            var allHRAbove5500 = Employees
                .Where(e => e.Department == "HR")
                .All(e => e.Salary > 5500);
            
            Console.WriteLine($"Do ALL HR employees earn more than 5500 ? {allHRAbove5500}");
            // another way ? what is the difference
            var allHRAbove5500_2 = Employees
                .All(e => e.Department == "HR" && e.Salary > 5500);
            Console.WriteLine($"Do ALL HR employees earn more than 5500 ? {allHRAbove5500_2}");

            Console.WriteLine("4.Project the top-2 - per - dept result into:");
                var topPaidEmployeesWithRank = Employees
                    .GroupBy(e => e.Department)
                    .SelectMany(g => g
                        .OrderByDescending(e => e.Salary)
                        .Take(2)
                        .Select((e, index) => new
                        {
                            Rank = index + 1,
                            Name = e.Name,
                            Department = e.Department,
                            Salary = e.Salary,
                            SeniorityLevel = (e.Salary) switch
                            {
                                >= 9000 => "Senior",
                                >= 7000 => "Mid",
                                _ => "Junior"
                            }
                        })
                    );
            foreach (var item in topPaidEmployeesWithRank)
            {
                  Console.WriteLine($"{item.Rank} - {item.Name} - {item.Department} - {item.Salary} - {item.SeniorityLevel}");
            }
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    public class Course
    {
        public string Title { get; set; }
        public List<string> Students { get; set; }
        public override string ToString()
        {
            return $"{Title} ({string.Join(", ", Students)})";
        }
    }
}
