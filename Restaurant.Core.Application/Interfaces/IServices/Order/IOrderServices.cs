using Restaurant.Core.Application.ViewModels.Order;
using Restaurant.Core.Domain.Entities.Order;

namespace Restaurant.Core.Application.Interfaces.IServices.Order
{
    public interface IOrderServices : IGenericService<SaveOrderViewModel, OrderViewModel, Orders>
    {

    }
}
