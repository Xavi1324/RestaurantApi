using Restaurant.Core.Application.ViewModels.DishesIngredient;
using Restaurant.Core.Domain.Entities.Relations;

namespace Restaurant.Core.Application.Interfaces.IServices.DishesIngredient
{
    public interface IDishIngredientServices : IGenericService<SaveDishIngredientViewModel, DishIngredientViewModel, DishIngredient>
    { 

    }
}
