namespace LINQ_Q4
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

            //1. Convert to Array
            var productsArray = products.ToArray();
            Console.WriteLine("Products as Array: ");
            foreach (var product in productsArray)
            {
                Console.Write(product);
                Console.Write(" ,");
                Console.WriteLine();
            }
            Console.WriteLine("*******************************************");
            //2. Convert to Dictionary
            var productsDictionary = products.ToDictionary(p => p.Id , p => $"Name: {p.Name}, Price: {p.Price}, Category: {p.Category}");
            Console.WriteLine("\nProducts as Dictionary: ");
            foreach (var kvp in productsDictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            } 
            Console.WriteLine("*******************************************");
            //3. Convert to HashSet
            var productsHashSet = products.ToHashSet();
            Console.WriteLine("\nProducts as HashSet: ");
            foreach (var product in productsHashSet)
            {
                Console.Write(product);
                Console.Write(" ,");
                Console.WriteLine();
            }
            //4. Convert to Lookup
            var productsLookup = products.ToLookup(p => p.Category);
            Console.WriteLine("\nProducts as Lookup: ");
            foreach (var group in productsLookup)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var product in group)
                {
                    Console.Write(product);
                    Console.Write(" ,");
                    Console.WriteLine();
                }
            }

            // ->What exception does ToDictionary throw if keys are duplicated?
            // - ToDictionary throws an ArgumentException, The exception message will indicate that an item with the same key has already been added.
            //->How does ToLookup handle duplicate keys differently?
            // - ToLookup allows duplicate keys and groups the values into an IGrouping<TKey, TElement> for each key. Each group contains all the elements that share the same key, so it does not throw an exception for duplicate keys.

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
}
