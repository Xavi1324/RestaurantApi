using Restaurant.Core.Application.ViewModels.Dish;
using Restaurant.Core.Domain.Entities.Dish;

namespace Restaurant.Core.Application.Interfaces.IServices.Dishe
{
    public interface IDishesServices : IGenericService<SaveDishViewModel, DishViewModel,Dishes>
    {
    }
}
