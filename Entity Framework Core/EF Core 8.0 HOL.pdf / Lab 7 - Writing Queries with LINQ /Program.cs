using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.DTOs;

namespace RetailInventory
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            var filteredProducts = await context.Products
                .Where(p => p.Price > 1000)
                .OrderByDescending(p => p.Price)
                .ToListAsync();

            Console.WriteLine("Filtered Products");
            Console.WriteLine();

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"{product.Name} - ₹{product.Price}");
            }

            Console.WriteLine();

            var productDTOs = await context.Products
                .Select(p => new ProductDTO
                {
                    Name = p.Name,
                    Price = p.Price
                })
                .ToListAsync();

            Console.WriteLine("Product DTOs");
            Console.WriteLine();

            foreach (var product in productDTOs)
            {
                Console.WriteLine($"{product.Name} - ₹{product.Price}");
            }
        }
    }
}
