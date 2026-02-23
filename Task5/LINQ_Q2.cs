namespace LINQ_Q2
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

            // 1. Get the first Electronics product
            var firstElectronics = products.FirstOrDefault(p => p.Category == "Electronics");
            Console.WriteLine(firstElectronics);


            // 2. Get the last product with Price > 1000 (use OrDefault — handle null)
            var lastProduct = products.LastOrDefault(p => p.Price > 1000);
            Console.WriteLine(lastProduct != null ? lastProduct : "No such product found");


            // 3. Get the single Furniture item with Price > 300 (what if >1 match?)
            var singleFurniture = products.SingleOrDefault(p => p.Category == "Furniture" && p.Price > 300); 
            Console.WriteLine(singleFurniture != null ? singleFurniture : "multiple matches");
            // if multiple matches the condition will throe an exception

            // 4. Get the element at index 3
            var elementAtIndex3 = products.ElementAtOrDefault(3);
            Console.WriteLine(elementAtIndex3);

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
