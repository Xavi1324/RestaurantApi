using Restaurant.Core.Application.ViewModels.DishesIngredient;
using Restaurant.Core.Domain.Entities.Enums;

namespace Restaurant.Core.Application.ViewModels.Dish
{
    public class DishViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Servings { get; set; }
        public DishCategory Category { get; set; }
        // Lista de ingredientes que conforman el plato
        public List<DishIngredientViewModel> Ingredients { get; set; } = new List<DishIngredientViewModel>();
    }
}
