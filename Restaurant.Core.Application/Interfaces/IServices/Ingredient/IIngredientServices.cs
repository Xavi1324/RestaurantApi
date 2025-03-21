using Restaurant.Core.Application.ViewModels.Ingredient;
using Restaurant.Core.Domain.Entities.Ingredient;

namespace Restaurant.Core.Application.Interfaces.IServices.Ingredient
{
    public interface IIngredientServices : IGenericService<SaveIngredientViewModel, IngredientViewModel, Ingredients>
    {

    }
}
