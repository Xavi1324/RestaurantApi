using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Core.Application.Interfaces.IServices.Dish;
using Restaurant.Core.Application.Interfaces.IServices.DishesIngredient;
using Restaurant.Core.Application.Interfaces.IServices.Ingredient;
using Restaurant.Core.Application.Interfaces.IServices.Order;
using Restaurant.Core.Application.Interfaces.IServices.OrderDishes;
using Restaurant.Core.Application.Interfaces.IServices.Table;

namespace Restaurant.Core.Application
{
    public static class ServicesRegistration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            

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
