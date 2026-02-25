namespace LINQ_Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>
            {
                new Course { Title = "C# Basics", Students = new List<string> { "Ali", "Sara", "Omar" } },
                new Course { Title = "LINQ Mastery", Students = new List<string> { "Sara", "Mona", "Ali" } },
                new Course { Title = "ASP.NET Core", Students = new List<string> { "Yara", "Omar", "Karim" } }
            };
            // 1. Flatten to a single list of ALL student names (with duplicates)
            Console.WriteLine("1. Flatten to a single list of ALL student names (with duplicates)");

            var allStudents = courses.SelectMany(c => c.Students);
            foreach (var item in allStudents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("2. Get a distinct list of all student names");
            var distinctStudents = courses.SelectMany(c => c.Students).Distinct();
                foreach (var item in distinctStudents)
                {
                    Console.WriteLine(item);
                }

            Console.WriteLine();
            Console.WriteLine("3. Find students who appear in MORE THAN ONE course");
            var studentsInMultipleCourses = courses
                .SelectMany(c => c.Students)
                .GroupBy(s => s) // "string" student name as key , grouping all occurrences of that name together
                .Where(g => g.Count() > 1) //
                .Select(g => g.Key);//

            foreach (var item in studentsInMultipleCourses)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            // 4. Use SelectMany with result selector to get (CourseName, StudentName) pairs
            var courseStudentPairs = courses.SelectMany(
                c => c.Students,
                (course, student) => new { 
                    CourseName = course.Title,
                    StudentName = student 
                }
            );
            foreach (var item in courseStudentPairs)
            {
                Console.WriteLine(item.CourseName +" - " + item.StudentName);
            }

        }
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
