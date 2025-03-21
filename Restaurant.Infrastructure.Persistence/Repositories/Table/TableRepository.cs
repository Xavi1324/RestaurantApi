using Restaurant.Core.Application.Interfaces.IRepositories.Table;
using Restaurant.Core.Domain.Entities.Table;
using Restaurant.Infrastructure.Persistence.Context;

namespace Restaurant.Infrastructure.Persistence.Repositories.Table
{
    public class TableRepository : GenericRepository<Tables> , ITableRepository
    {
        private readonly RestaurantApiContext _context;
        public TableRepository(RestaurantApiContext context) : base(context)
        {
            _context = context;
        }
    }
}
