using Restaurant.Core.Domain.Common;
using Restaurant.Core.Domain.Entities.Enums;
using Restaurant.Core.Domain.Entities.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Domain.Entities.Dish
{
    public class Dishes : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Servings { get; set; }
        public DishCategory Category { get; set; }
        
        public ICollection<DishIngredient> Ingredients { get; set; } = new List<DishIngredient>();

        public ICollection<OrderDish> OrderDishes { get; set; } = new List<OrderDish>();

    }
}
