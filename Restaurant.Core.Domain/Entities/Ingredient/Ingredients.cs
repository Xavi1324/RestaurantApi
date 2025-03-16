using Restaurant.Core.Domain.Common;
using Restaurant.Core.Domain.Entities.Relations;

namespace Restaurant.Core.Domain.Entities.Ingredient
{
    public class Ingredients : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<DishIngredient> Dishes { get; set; } = new List<DishIngredient>();
    }
}
