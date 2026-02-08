using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace C_App1
{
    internal class App1
    {

        static void Main(string[] args)
        {

            List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ShowArr(numbers, out List<int> evens, out List<int> Odds, out List<int> primes);

            Console.WriteLine("Evens: " + string.Join(",",evens));
            Console.WriteLine("odda: " + string.Join(",", Odds));
            Console.WriteLine("Primes: " + string.Join(",", primes));

        }

        public static void ShowArr(List<int> nums ,out List<int>evens ,out List<int>Odds ,out List<int>primes)
        {

            evens = new List<int>();
            Odds = new List<int>();
            primes = new List<int>();

            for (var num = 0; num < nums.Count(); num++)
            {
                if (isEvenORodd(nums[num]))
                {
                    evens.Add(nums[num]);
                }
                else if (!isEvenORodd(nums[num])) { 
                    Odds.Add(nums[num]);
                }
                else if (isPrime(nums[num]))
                {
                    primes.Add(nums[num]);
                }
            }

        }
        static bool isEvenORodd(int n)
        {
            return n % 2 == 0 ? true : false;
        }
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            for(int i=2;i*i<=n;i++)
            {
                if (n % i == 0) return false; 
            }
            return true;
        }
    }
}

