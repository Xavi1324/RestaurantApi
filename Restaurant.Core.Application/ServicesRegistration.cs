using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Core.Application.Interfaces.IServices.Dishe;
using Restaurant.Core.Application.Interfaces.IServices.DishesIngredient;
using Restaurant.Core.Application.Interfaces.IServices.Ingredient;
using Restaurant.Core.Application.Interfaces.IServices.Order;
using Restaurant.Core.Application.Interfaces.IServices.OrderDishes;
using Restaurant.Core.Application.Interfaces.IServices.Table;
using Restaurant.Core.Application.Services.Dish;
using Restaurant.Core.Application.Services.DishesIngredient;
using Restaurant.Core.Application.Services.Ingredient;
using Restaurant.Core.Application.Services.Order;
using Restaurant.Core.Application.Services.OrderDishes;
using Restaurant.Core.Application.Services.Table;
using System.Reflection;

namespace Restaurant.Core.Application
{
    public static class ServicesRegistration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            #region Services dependencies injection

            services.AddTransient<IDishesServices, DishesServices>();
            services.AddTransient<IDishIngredientServices, DishIngredientServices>();
            services.AddTransient<IIngredientServices, IngredientServices>();
            services.AddTransient<IOrderServices, OrderServices>();
            services.AddTransient<IOrdersDishServices, OrdersDishServices>();
            services.AddTransient<ITableServices, TableServices>();

            #endregion

        }
    }
}
