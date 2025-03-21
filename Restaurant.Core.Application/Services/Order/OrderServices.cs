using AutoMapper;
using Restaurant.Core.Application.Interfaces.IRepositories.Order;
using Restaurant.Core.Application.Interfaces.IServices.Order;
using Restaurant.Core.Application.ViewModels.Order;
using Restaurant.Core.Domain.Entities.Order;

namespace Restaurant.Core.Application.Services.Order
{
    public class OrderServices : GenericServices<SaveOrderViewModel, OrderViewModel, Orders>, IOrderServices
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public OrderServices(IOrderRepository orderRepository, IMapper mapper) : base(orderRepository, mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }
    }
}
