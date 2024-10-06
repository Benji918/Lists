using System.Threading.Channels;

namespace Lists
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();


            products.Add(new Product {Name = "DDF", Price = 34.4});
            products.Add(new Product {Name = "sds", Price = 4.4});
            products.Add(new Product {Name = "DDF", Price = 2.4});

            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} for price {product.Price}");
            }

            List<Product> Cheapproducts = products.Where(j => j.Price < 3.0).ToList();

            foreach (Product product in Cheapproducts)
            {
                Console.WriteLine($"{product.Name}");
            }
            int? number = null;

            string result = (number.HasValue) ? number.Value.ToString() : "Empty"; 
            Console.WriteLine(result);

            List<int> integers = [2333, 24, 33355];
            

            integers.Sort();

            /*foreach (int i in integers)
            {
                Console.Write(i + " ");
            }*/

            bool HasLargeNumber =  integers.Any(x => x>100);

            if (HasLargeNumber)
            {
                Console.WriteLine("There are large numbers!");
            }
            else
            {
                Console.WriteLine("There are no large numbers");
            }
            
            Console.ReadKey();    
        }
    }
}
