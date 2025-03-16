using Restaurant.Core.Application.Interfaces.IRepositories.Order;
using Restaurant.Core.Domain.Entities.Order;
using Restaurant.Infrastructure.Persistence.Context;

namespace Restaurant.Infrastructure.Persistence.Repositories.Order
{
    public class OrderRepository : GenericRepository<Orders>, IOrderServices
    {
        private readonly RestaurantApiContext _context;
        public OrderRepository(RestaurantApiContext context) : base(context)
        {
            _context = context;
        }
    }
}
