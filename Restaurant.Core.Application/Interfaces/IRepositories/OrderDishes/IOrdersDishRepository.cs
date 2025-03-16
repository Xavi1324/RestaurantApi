using Restaurant.Core.Domain.Entities.Dish;
using Restaurant.Core.Domain.Entities.Relations;

namespace Restaurant.Core.Application.Interfaces.IRepositories.OrderDishes
{
    public interface IOrdersDishServices : IGenericRepository<OrderDish>
    {
        Task<List<Dishes>> GetDishesByOrderIdAsync(int orderId);
    }
}
