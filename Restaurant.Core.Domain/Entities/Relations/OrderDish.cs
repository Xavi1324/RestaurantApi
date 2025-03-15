using Restaurant.Core.Domain.Common;
using Restaurant.Core.Domain.Entities.Dish;
using Restaurant.Core.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Core.Domain.Entities.Relations
{
    public class OrderDish : BaseEntity
    {
        public int OrderId { get; set; }
        public Orders Order { get; set; }
        public int DishId { get; set; }
        public Dishes Dish { get; set; }
        public int Quantity { get; set; }
    }
}
