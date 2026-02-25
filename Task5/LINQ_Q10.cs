namespace LINQ_Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "apple", "fig", "banana", "Kiwi", "grape", "mango", "pear", "plum" };
            Console.WriteLine("1. Filter words longer than 4 characters");
            var longerThan4 = words.Where(word => word.Length > 4).ToList();
            foreach (var item in longerThan4)
            {
                Console.Write($" {item}");
            }
            Console.WriteLine("\n2. Filter words at even indexes (0, 2, 4, 6...) using (item, index) overload");
            var evenIndexWords = words.Where((word, index) => index % 2 == 0).ToList();
            foreach (var item in evenIndexWords)
            {
                Console.Write($" {item}");
            }
            // 3. Filter words that are BOTH longer than 4 chars AND at an even index
            Console.WriteLine("\n3. Filter words that are BOTH longer than 4 chars AND at an even index");
            var longerThan4EvenIndex = words.Where((word, index) => word.Length > 4 && index % 2 == 0).ToList();
            foreach (var item in longerThan4EvenIndex)
            {
                Console.Write($" {item}");
            }
            // 4. What is the index of "mango" in the filtered result from step 1?
            Console.WriteLine("\n4. What is the index of \"mango\" in the filtered result from step 1?");
            int indexOfMango = longerThan4.IndexOf("mango");
            Console.WriteLine($"index_Of_Mango: {indexOfMango}");
        }
    }
}
