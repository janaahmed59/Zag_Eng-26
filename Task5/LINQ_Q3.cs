using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop",     Price = 1200m,Category = "Electronics" },
                new Product { Id = 2, Name = "Phone",      Price = 800m, Category = "Electronics" },
                new Product { Id = 3, Name = "Desk",       Price = 350m, Category = "Furniture" },
                new Product { Id = 4, Name = "Chair",      Price = 150m, Category = "Furniture" },
                new Product { Id = 5, Name = "Headphones", Price = 200m, Category = "Electronics" }
            };

            //1. Are ALL products priced above 100?
            var query1 = products.All(p => p.Price > 100);
            Console.WriteLine($"Are ALL products priced above 100? {query1}");

            //2. Is THERE ANY product in the "Gaming" category? → bool
            var query2 = products.Any(p => p.Category == "Gaming");
            Console.WriteLine($"Is THERE ANY product in the 'Gaming' category ? { query2}");

            //3. Does the collection CONTAIN a product named "Chair"?
            //(use the default comparer on the record)
            //var query3 = products.Contains();

            //4. Are ALL Electronics products priced above 500?
            var query4 = products.All(p => p.Category == "Electronics" && p.Price > 500);
            Console.WriteLine($"Are ALL Electronics products priced above 500? {query4}");//false id=5 price = 200

            //5.Is there ANY product cheaper than 200 ? 
            var query5 = products.Any(p => p.Price < 200);
            Console.WriteLine($"Is there ANY product cheaper than 200? {query5}");

        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: (${Price}), Category: {Category}";
        }
    }

}
