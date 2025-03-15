using Restaurant.Core.Domain.Common;
using Restaurant.Core.Domain.Entities.Dish;
using Restaurant.Core.Domain.Entities.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Domain.Entities.Relations
{
    public class DishIngredient : BaseEntity
    {
        public int DishId { get; set; }
        public Dishes Dish { get; set; }
        public int IngredientId { get; set; }
        public Ingredients Ingredient { get; set; }
        public int Quantity { get; set; }
    }
}
