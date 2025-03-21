using Restaurant.Core.Application.ViewModels.OrderDishes;
using Restaurant.Core.Domain.Entities.Relations;

namespace Restaurant.Core.Application.Interfaces.IServices.OrderDishes
{
    public interface IOrdersDishServices : IGenericService<SaveOrderDishViewModel, OrderDishViewModel, OrderDish>
    {
        
    }
}
