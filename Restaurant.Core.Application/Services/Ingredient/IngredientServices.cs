using AutoMapper;
using Restaurant.Core.Application.Interfaces.IRepositories.Ingredient;
using Restaurant.Core.Application.Interfaces.IServices.Ingredient;
using Restaurant.Core.Application.ViewModels.Ingredient;
using Restaurant.Core.Domain.Entities.Ingredient;

namespace Restaurant.Core.Application.Services.Ingredient
{
    public class IngredientServices : GenericServices<SaveIngredientViewModel, IngredientViewModel, Ingredients>, IIngredientServices
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IMapper _mapper;
        public IngredientServices(IIngredientRepository ingredientRepository, IMapper mapper) : base(ingredientRepository, mapper)
        {
            _ingredientRepository = ingredientRepository;
            _mapper = mapper;
        }
    }
}
