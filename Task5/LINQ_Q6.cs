namespace LINQ_Q6
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
            Console.WriteLine("1******************************************************");
            // 1. Project to anonymous type: { FullName = Name.ToUpper(), Salary }
            var query = Employees.Select(e => new
            {
                FullName = e.Name.ToUpper(),
                Salary = e.Salary
            });
            foreach (var item in query)
            {
                Console.WriteLine($"FullName: {item.FullName}, Salary: {item.Salary}");
            }
            Console.WriteLine("2******************************************************");
            // 2. Project to a formatted string: "Ali works in Engineering — EGP 9,000"
            var Query = Employees.Where(e => e.Name == "Ali")
                .Select(e => e.Name + " works in " + e.Department + " - EGP " + e.Salary);

            foreach (var item in Query)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("another solution:");
            // another solution: *based on Ali is the first employee, we can use take(1) pr firstOrDefault()
            var Query2 = Employees.Take(1)
            .Select(e => e.Name + " works in " + e.Department + " - EGP " + e.Salary);
            foreach (var item in Query2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("3******************************************************");

            // 3. Sort by Salary descending, then use indexed Select to add Rank:
            // { Rank = index + 1, Name, Salary }
            var Query3 = Employees.OrderByDescending(e => e.Salary)
                .Select((e, index) => new
                {
                    Rank = index + 1,
                    Name = e.Name,
                    Salary = e.Salary
                });
            foreach (var item in Query3)
            {
                Console.WriteLine($"Rank: {item.Rank}, Name: {item.Name}, Salary: {item.Salary}");
            }
        
            // Expected: { Rank=1, Name="Nada"

        }
        public class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }
        }
    }
}
