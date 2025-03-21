using Microsoft.EntityFrameworkCore;
using Restaurant.Core.Application.Interfaces.IRepositories.OrderDishes;
using Restaurant.Core.Domain.Entities.Dish;
using Restaurant.Core.Domain.Entities.Relations;
using Restaurant.Infrastructure.Persistence.Context;
namespace Restaurant.Infrastructure.Persistence.Repositories.OrderDishes
{
    public class OrdersDishRepository : GenericRepository<OrderDish>, IOrdersDishRepository
    {
        private readonly RestaurantApiContext _context;
        public OrdersDishRepository(RestaurantApiContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Dishes>> GetDishesByOrderIdAsync(int orderId)
        {
            return await _context.OrderDishes
                             .Where(od => od.OrderId == orderId)
                             .Select(od => od.Dish)
                             .ToListAsync();
        }
    }
}
