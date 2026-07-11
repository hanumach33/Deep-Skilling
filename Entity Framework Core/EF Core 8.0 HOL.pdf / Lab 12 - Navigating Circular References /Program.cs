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

            var productDTOs = await context.Products
                .Include(p => p.Category)
                .Select(p => new ProductDTO
                {
                    Name = p.Name,
                    CategoryName = p.Category.Name
                })
                .ToListAsync();

            foreach (var product in productDTOs)
            {
                Console.WriteLine($"{product.Name} - {product.CategoryName}");
            }
        }
    }
}
