using Restaurant.Core.Domain.Entities.Dish;
using Restaurant.Core.Domain.Entities.Ingredient;
using Restaurant.Core.Domain.Entities.Relations;

namespace Restaurant.Core.Application.Interfaces.IRepositories.DishesIngredient
{
    public interface IDishIngredientServices : IGenericRepository<DishIngredient>
    {
        Task<List<Ingredients>> GetIngredientsByDishIdAsync(int dishId);
        Task<List<Dishes>> GetDishesByIngredientIdAsync(int ingredientId);
       
    }
}
