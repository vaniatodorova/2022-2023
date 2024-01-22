using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Product> products = new List<Product>()
			{
				new Product("Apple", 1.99m),
				new Product("Banana", 0.99m),
				new Product("Orange", 2.49m),
				new Product("Pineapple", 3.99m),
				new Product("Grapefruit", 1.79m),
			};
			Console.WriteLine("All products:");
			PrintProducts(products);
			var expensiveProducts = products.Where(p => p.Price > 2.0m);
			Console.WriteLine("Expensive products:");
			PrintProducts(expensiveProducts);
		}
		static void PrintProducts(IEnumerable<Product> products)
		{
			foreach(var product in products)
			{
				Console.WriteLine(product.Name + " - " + product.Price.ToString("C"));
			}
		}
	}
	class Product
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public Product(string name, decimal price)
		{
			Name = name;
			Price = price;
		}
	}
}
