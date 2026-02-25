namespace LINQ_Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEFERRED EXECUTION");
            Console.WriteLine("______________________");
            List<int> nums = new List<int> { 1, 2, 3, 4, 5 };
            var query = nums.Where(n => n > 2); // query Defined here ,just defined but not executed 

            nums.Add(10); // modified -> source will be changed ,when we execute the query it will execute on the modified source
            foreach (var item in query) // query executed here -> on modified source
            {
                Console.WriteLine(item); // 3 4 5 10
            }

            Console.WriteLine("IMMEDIATE EXECUTION");
            Console.WriteLine("______________________");
            List<int> nums2 = new List<int> { 1, 2, 3, 4, 5 };
            var query1 = nums2.Where(n => n > 2).ToList(); // query defined and executed here -> on modified source
            nums2.Add(10); // modified -> source will be changed ,but query1 is already executed on the the defined source so it will not affect the result of query1

            foreach (var item in query1)
            {
                Console.WriteLine(item); // 3 4 5 // query1 is a list that contains the result of the query at the time of execution, so it will not reflect any changes made to the source after the query was executed    
            }
        }
    }
}
