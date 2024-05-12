using Microsoft.EntityFrameworkCore;

namespace WebAPIK8s
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DbContextClass(serviceProvider.GetRequiredService<DbContextOptions<DbContextClass>>()))
            {
                if (context.Customers.Any()) { return; }
                context.Customers.AddRange(new CustomerDetails { CustomerId = 1, CustomerName = "Arif", CustomerAddress = "Delhi", CustomerNumber = 7454947490, CustomerPinCode = 244001 });
                context.SaveChanges();
            }
        }
    }
}
