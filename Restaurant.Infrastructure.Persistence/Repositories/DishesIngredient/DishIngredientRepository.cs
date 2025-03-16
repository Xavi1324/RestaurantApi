using Microsoft.EntityFrameworkCore;
using Restaurant.Core.Application.Interfaces.IRepositories.DishesIngredient;
using Restaurant.Core.Domain.Entities.Dish;
using Restaurant.Core.Domain.Entities.Ingredient;
using Restaurant.Core.Domain.Entities.Relations;
using Restaurant.Infrastructure.Persistence.Context;

namespace Restaurant.Infrastructure.Persistence.Repositories.DishesIngredient
{
    public class DishIngredientRepository : GenericRepository<DishIngredient>, IDishIngredientServices
    {
        private readonly RestaurantApiContext _context;
        public DishIngredientRepository(RestaurantApiContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Dishes>> GetDishesByIngredientIdAsync(int ingredientId)
        {
            return await  _context.DishIngredients
                                  .Where(di => di.IngredientId == ingredientId)
                                  .Select(di => di.Dish)
                                  .ToListAsync();
        }

        public async Task<List<Ingredients>> GetIngredientsByDishIdAsync(int dishId)
        {
            return await _context.DishIngredients
                                 .Where(di => di.DishId == dishId)
                                 .Select(di => di.Ingredient)
                                 .ToListAsync();
        }
    }
}
