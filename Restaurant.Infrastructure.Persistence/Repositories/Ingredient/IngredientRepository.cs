using Restaurant.Core.Application.Interfaces.IRepositories.Ingredient;
using Restaurant.Core.Domain.Entities.Ingredient;
using Restaurant.Infrastructure.Persistence.Context;

namespace Restaurant.Infrastructure.Persistence.Repositories.Ingredient
{
    public class IngredientRepository : GenericRepository<Ingredients> ,IIngredientServices
    {
        private readonly RestaurantApiContext _context;
        public IngredientRepository(RestaurantApiContext context) : base(context)
        {
            _context = context;
        }

    }
}
