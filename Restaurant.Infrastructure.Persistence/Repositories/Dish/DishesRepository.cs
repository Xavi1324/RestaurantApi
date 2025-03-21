using Restaurant.Core.Application.Interfaces.IRepositories.Dish;
using Restaurant.Core.Domain.Entities.Dish;
using Restaurant.Infrastructure.Persistence.Context;

namespace Restaurant.Infrastructure.Persistence.Repositories.Dish
{
    public class DishesRepository : GenericRepository<Dishes>, IDishesRepository
    {
        private readonly RestaurantApiContext _context;

        public DishesRepository(RestaurantApiContext context) : base(context)
        {
            _context = context;
        }

    }
}
