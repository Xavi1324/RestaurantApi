using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Core.Application.Interfaces.IRepositories;
using Restaurant.Core.Application.Interfaces.IRepositories.Dish;
using Restaurant.Core.Application.Interfaces.IRepositories.DishesIngredient;
using Restaurant.Core.Application.Interfaces.IRepositories.Ingredient;
using Restaurant.Core.Application.Interfaces.IRepositories.Order;
using Restaurant.Core.Application.Interfaces.IRepositories.OrderDishes;
using Restaurant.Core.Application.Interfaces.IRepositories.Table;
using Restaurant.Infrastructure.Persistence.Context;
using Restaurant.Infrastructure.Persistence.Repositories;
using Restaurant.Infrastructure.Persistence.Repositories.Dish;
using Restaurant.Infrastructure.Persistence.Repositories.DishesIngredient;
using Restaurant.Infrastructure.Persistence.Repositories.Ingredient;
using Restaurant.Infrastructure.Persistence.Repositories.Order;
using Restaurant.Infrastructure.Persistence.Repositories.OrderDishes;
using Restaurant.Infrastructure.Persistence.Repositories.Table;

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

            #region Repositories dependencies injection
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IDishesServices, DishesRepository>();
            services.AddTransient<IDishIngredientServices, DishIngredientRepository>();
            services.AddTransient<IIngredientServices, IngredientRepository>();
            services.AddTransient<IOrderServices, OrderRepository>();
            services.AddTransient<IOrdersDishServices, OrdersDishRepository>();
            services.AddTransient<ITableServices, TableRepository>();

            #endregion

        }
    }
}
