using Restaurant.Core.Domain.Common;
using Restaurant.Core.Domain.Entities.Enums;
using Restaurant.Core.Domain.Entities.Relations;
using Restaurant.Core.Domain.Entities.Table;

namespace Restaurant.Core.Domain.Entities.Order
{
    public class Orders : BaseEntity
    {
        public int TableId { get; set; }
        public Tables Table { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.InProcess;
        public int Subtotal { get; set; }
        public ICollection<OrderDish> OrderDishes { get; set; } = new List<OrderDish>();

    }
}
