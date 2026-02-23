namespace LINQ_Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int> {88, 92, 75, 60, 55, 80, 91, 45 };

            // 1. TakeWhile score >= 70 → expected: [88, 92, 75]
            var TakeWhileRes= scores.TakeWhile(score => score >= 70);
            foreach (var item in TakeWhileRes)
            {
                Console.WriteLine(item);
            }
            // 2. SkipWhile score >= 70 → expected: [60, 55, 80, 91, 45]
            var SkipWhileRes = scores.SkipWhile(score => score >= 70);
            foreach (var item in SkipWhileRes)
            {
                Console.WriteLine(item);
            }
            // 3. What is the difference between this and using Where? Explain in a comment.
            // TakeWhile and SkipWhile operate on the sequence until the condition is no longer met.( false اول ما يبقي )
            // where evaluates the condition for each element in the entire collection, regardless of order(Condition يحقق element بيفضل شفال علي اي).
        }
    }
}
