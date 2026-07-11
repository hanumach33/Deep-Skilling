using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

namespace RetailInventory
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            try
            {
                var product = await context.Products
                    .FirstOrDefaultAsync(p => p.Id == 1);

                if (product != null)
                {
                    product.StockQuantity += 10;

                    await context.SaveChangesAsync();

                    Console.WriteLine("Product updated successfully.");
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                Console.WriteLine("Concurrency conflict detected.");
            }
        }
    }
}
