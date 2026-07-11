using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using EFCore.BulkExtensions;

namespace RetailInventory
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            var productList = await context.Products.ToListAsync();

            foreach (var product in productList)
            {
                product.StockQuantity += 10;
            }

            await context.BulkUpdateAsync(productList);

            Console.WriteLine("Bulk update completed successfully.");

            Console.WriteLine();
            Console.WriteLine("Updated Products");
            Console.WriteLine();

            foreach (var product in productList)
            {
                Console.WriteLine(
                    $"{product.Name} - Stock: {product.StockQuantity}"
                );
            }
        }
    }
}
