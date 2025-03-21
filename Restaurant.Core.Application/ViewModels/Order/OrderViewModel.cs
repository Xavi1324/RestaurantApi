using Restaurant.Core.Application.ViewModels.OrderDishes;
using Restaurant.Core.Domain.Entities.Enums;

namespace Restaurant.Core.Application.ViewModels.Order
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public OrderStatus Status { get; set; }
        public int Subtotal { get; set; }
        // Lista de platos que componen la orden
        public List<OrderDishViewModel> OrderDishes { get; set; } = new List<OrderDishViewModel>();
    }
}
