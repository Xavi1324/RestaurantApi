using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Infrastructure.Persistence
{
    public static class ServicesRegistration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<RestaurantApiContext>(options =>
                    options.UseInMemoryDatabase("RestaurantDbInMemory"));
            }
            else
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                services.AddDbContext<RestaurantApiContext>(options =>
                options.UseSqlServer(connectionString, m => m.MigrationsAssembly(typeof(RestaurantApiContext).Assembly.FullName)));
            }

        }
    }
}
