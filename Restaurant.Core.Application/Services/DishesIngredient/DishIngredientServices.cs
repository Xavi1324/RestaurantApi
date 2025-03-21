using AutoMapper;
using Restaurant.Core.Application.Interfaces.IRepositories.DishesIngredient;
using Restaurant.Core.Application.Interfaces.IServices.DishesIngredient;
using Restaurant.Core.Application.ViewModels.DishesIngredient;
using Restaurant.Core.Domain.Entities.Relations;

namespace Restaurant.Core.Application.Services.DishesIngredient
{
    public class DishIngredientServices : GenericServices<SaveDishIngredientViewModel,DishIngredientViewModel,DishIngredient > ,  IDishIngredientServices
    { 
        private readonly IDishIngredientRepository _dishIngredientRepository;
        private readonly IMapper _mapper;

        public DishIngredientServices(IDishIngredientRepository dishIngredientRepository, IMapper mapper) : base(dishIngredientRepository, mapper)
        {
            _dishIngredientRepository = dishIngredientRepository;
            _mapper = mapper;
        }

    }
}
