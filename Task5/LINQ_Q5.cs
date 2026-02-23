namespace LINQ_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var num = nums.SkipWhile(n => n < 4);
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            List<string> orders = new List<string>
            {
                "ORD-001",
                "ORD-002",
                "ORD-003",
                "ORD-004",
                "ORD-005",
                "ORD-006",
                "ORD-007"
            };
            // 1. Get Page 1 (items 1–3)
            var Page1 = orders.Take(3);
            Console.WriteLine("Page1 has first 3 orders");
            foreach (var item in Page1)
            {
                 Console.WriteLine(item);
            }
            // 2. Get Page 2 (items 4–6) ← use Skip + Take
            var page2 = orders.Skip(3).Take(3);
            Console.WriteLine("Page1 has second 3 orders(4-6)");
            foreach (var item in page2)
            {
                Console.WriteLine(item);
            }
            // 3. Get the last 2 orders using TakeLast
            var last2Orders = orders.TakeLast(2);
            Console.WriteLine("Last 2 orders");
            foreach (var item in last2Orders)
            {
                Console.WriteLine(item);
            }

            // 4. Drop the first and last order using Skip + SkipLast
             var dropFirstAndLast = orders.Skip(1).SkipLast(1);
            Console.WriteLine("Drop the first and last order");
            foreach (var item in dropFirstAndLast)
            {
                Console.WriteLine(item);
            }
            // 5. BONUS: Write a generic Paginate(source, pageNumber, pageSize) method
            var genericPaginate = Paginate(orders, 3, 3);
            Console.WriteLine("Generic Paginate method for page 3 with page size 10");
            foreach (var item in genericPaginate)
            {
                Console.WriteLine(item);
            }
        }
        // 5. BONUS: Write a generic Paginate(source, pageNumber, pageSize) method
        public static IEnumerable<T> Paginate<T>(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            return source.Skip((pageNumber - 1) * pageSize).Take(pageSize); // Deferred..
            //execution, so it will only execute when the result is enumerated
        }

    }
}
