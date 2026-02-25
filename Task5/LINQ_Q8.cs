namespace LINQ_Q8
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
            Console.WriteLine("1. Group by Department, print: Engineering → Count: 3, Avg: 9000 ");
            var departmentGroups = Employees.GroupBy(e => e.Department)
                                            .Select(e => new
                                            {
                                                Dept = e.Key,
                                                count = e.Count(),
                                                Avg = e.Average(emp => emp.Salary)
                                            });
            foreach (var item in departmentGroups)
            {
                Console.WriteLine($"{item.Dept} → Count: {item.count}, Avg: {item.Avg}");
            }
            Console.WriteLine("\n2.Find the department with the highest total salary budget");
            var HighestTotalSalaryDept = Employees.GroupBy(e => e.Department)
                                        .Select(g => new
                                        {
                                            Dept = g.Key,
                                            TotalSalary = g.Sum(emp => emp.Salary)
                                        });
            foreach (var item in HighestTotalSalaryDept)
            {
                Console.WriteLine($"{item.Dept} → Total Salary: {item.TotalSalary}");
            }
            Console.WriteLine("\n3. List employees in each group ordered by Salary descending");
            var EmployeesByDepartment = Employees.GroupBy(e => e.Department)
                                            .Select(g => new
                                            {
                                                Dept = g.Key,
                                                Employees = g.OrderByDescending(emp => emp.Salary)
                                            });
            foreach (var group in EmployeesByDepartment)
            {
                Console.WriteLine($"{group.Dept}:");
                foreach (var emp in group.Employees)
                {
                    Console.WriteLine($" {emp.Name} - Salary: {emp.Salary}");
                }

            }

        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
}
