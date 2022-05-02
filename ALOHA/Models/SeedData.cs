using Microsoft.EntityFrameworkCore;
using ALOHA.Data;

namespace ALOHA.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ALOHAContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<ALOHAContext>>()))
            {
                if (context == null || context.Item == null)
                {
                    throw new ArgumentNullException("Null AlOHAContext");
                }
                if (context.Item.Any())
                {
                    return;
                }
                context.Item.AddRange(
                    new Item
                    {
                        ProductName = "Wedding Dress",
                        Date = DateTime.Parse("2022- 4-28"),
                        Quantity = 1,
                        Price = 12.5m
                    },
                    new Item
                    {
                        ProductName = "Suit",
                        Date = DateTime.Parse("2022- 4-28"),
                        Quantity = 1,
                        Price = 10m
                    },
                    new Item
                    {
                        ProductName = "Gown",
                        Date = DateTime.Parse("2022- 4-28"),
                        Quantity = 1,
                        Price = 55m
                    }
                     );
                context.SaveChanges();
            }
        }
    }
}

