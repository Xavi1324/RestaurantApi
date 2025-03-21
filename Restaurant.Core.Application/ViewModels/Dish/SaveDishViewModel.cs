using Restaurant.Core.Application.ViewModels.DishesIngredient;
using Restaurant.Core.Domain.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Application.ViewModels.Dish
{
    public class SaveDishViewModel
    {
        [Required(ErrorMessage = "El nombre del plato es obligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El precio del plato es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "El número de porciones es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de porciones debe ser mayor a 0.")]
        public int Servings { get; set; }

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public DishCategory Category { get; set; }

        [Required(ErrorMessage = "La lista de ingredientes es obligatoria.")]
        [MinLength(1, ErrorMessage = "Debe haber al menos un ingrediente.")]
        public List<SaveDishIngredientViewModel> Ingredients { get; set; } = new List<SaveDishIngredientViewModel>();
    }
}
