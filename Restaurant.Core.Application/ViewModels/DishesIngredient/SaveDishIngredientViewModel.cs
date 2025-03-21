using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Application.ViewModels.DishesIngredient
{
    public class SaveDishIngredientViewModel
    {
        [Required(ErrorMessage = "El ID del ingrediente es obligatorio.")]
        public int IngredientId { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0.")]
        public int Quantity { get; set; }
    }
}
