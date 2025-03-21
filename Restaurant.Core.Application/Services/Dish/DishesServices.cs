using AutoMapper;
using Restaurant.Core.Application.Interfaces.IRepositories.Dish;
using Restaurant.Core.Application.Interfaces.IServices.Dishe;
using Restaurant.Core.Application.ViewModels.Dish;
using Restaurant.Core.Domain.Entities.Dish;

namespace Restaurant.Core.Application.Services.Dish
{
    public class DishesServices : GenericServices<SaveDishViewModel, DishViewModel, Dishes> , IDishesServices
    {
        private readonly IDishesRepository _dishesRepository;
        private readonly IMapper _mapper;

        public DishesServices(IDishesRepository dishesRepository, IMapper mapper) : base(dishesRepository, mapper)
        {
            _dishesRepository = dishesRepository;
            _mapper = mapper;
        }
    }
}
