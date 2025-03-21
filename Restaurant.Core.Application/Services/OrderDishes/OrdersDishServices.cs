using AutoMapper;
using Restaurant.Core.Application.Interfaces.IRepositories.OrderDishes;
using Restaurant.Core.Application.Interfaces.IServices.OrderDishes;
using Restaurant.Core.Application.ViewModels.OrderDishes;
using Restaurant.Core.Domain.Entities.Relations;

namespace Restaurant.Core.Application.Services.OrderDishes
{
    public class OrdersDishServices : GenericServices<SaveOrderDishViewModel, OrderDishViewModel, OrderDish>, IOrdersDishServices
    {
        private readonly IOrdersDishRepository _orderDishRepository;
        private readonly IMapper _mapper;
        public OrdersDishServices(IOrdersDishRepository orderDishRepository, IMapper mapper) : base(orderDishRepository, mapper)
        {
            _orderDishRepository = orderDishRepository;
            _mapper = mapper;
        }
    }
}
