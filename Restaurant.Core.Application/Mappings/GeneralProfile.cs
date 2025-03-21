using AutoMapper;
using Restaurant.Core.Application.ViewModels.Dish;
using Restaurant.Core.Application.ViewModels.DishesIngredient;
using Restaurant.Core.Application.ViewModels.Ingredient;
using Restaurant.Core.Application.ViewModels.Order;
using Restaurant.Core.Application.ViewModels.OrderDishes;
using Restaurant.Core.Application.ViewModels.Table;
using Restaurant.Core.Domain.Entities.Dish;
using Restaurant.Core.Domain.Entities.Ingredient;
using Restaurant.Core.Domain.Entities.Order;
using Restaurant.Core.Domain.Entities.Relations;
using Restaurant.Core.Domain.Entities.Table;

namespace Restaurant.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            // Mapeo de Dishes a DishViewModel:
            CreateMap<Dishes, DishViewModel>()
                // Mapea la colección Ingredients usando el mapping definido para DishIngredient
                .ForMember(dest => dest.Ingredients,
                           opt => opt.MapFrom(src => src.Ingredients));
            CreateMap<Dishes, SaveDishViewModel>().ReverseMap();
            // OrderDishes se ignora porque no existe en DishViewModel

            // Mapeo de DishIngredient a DishIngredientViewModel:
            CreateMap<DishIngredient, DishIngredientViewModel>()
                .ForMember(dest => dest.IngredientName,
                           opt => opt.MapFrom(src => src.Ingredient.Name));
            CreateMap<DishIngredient, SaveDishIngredientViewModel>().ReverseMap();

            // IngredientId y Quantity se mapean automáticamente

            // Mapeo de Ingredients a IngredientViewModel:
            CreateMap<Ingredients, IngredientViewModel>();
            CreateMap<Ingredients, SaveIngredientViewModel>().ReverseMap();


            // Mapeo de OrderDish a OrderDishViewModel:
            CreateMap<OrderDish, OrderDishViewModel>()
                .ForMember(dest => dest.DishName,
                           opt => opt.MapFrom(src => src.Dish.Name));
            CreateMap<OrderDish, SaveOrderDishViewModel>().ReverseMap();

            // DishId y Quantity se mapean automáticamente

            // Mapeo de Orders a OrderViewModel:
            CreateMap<Orders, OrderViewModel>()
                .ForMember(dest => dest.OrderDishes,
                           opt => opt.MapFrom(src => src.OrderDishes));
            CreateMap<Orders, SaveOrderViewModel>().ReverseMap();


            // Mapeo de Tables a TableViewModel:
            CreateMap<Tables, TableViewModel>();
            CreateMap<Tables, SaveTableViewModel>().ReverseMap();

        }
    }
}
