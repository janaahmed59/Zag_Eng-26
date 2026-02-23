namespace LINQ_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = [3, 18, 7, 42, 10, 5, 29, 14, 6, 100];
            // TODO: Write the query using Query Syntax
            var res1 = from n in numbers
                       where n%2 == 0 && n>10
                       orderby n descending
                       select n;

            foreach (var n in res1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("********************************");
            // TODO: Write the same query using Fluent Syntax
            var res2 = numbers.Where(n => n % 2 == 0 && n > 10).OrderByDescending(n => n);
            foreach (var n in res2)
            {
                Console.WriteLine(n);
            }

            // Expected output: 100, 42, 18, 14
        }
    }
}
