using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Application.ViewModels.OrderDishes
{
    public class SaveOrderDishViewModel
    {
        [Required(ErrorMessage = "El ID del plato es obligatorio.")]
        public int DishId { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0.")]
        public int Quantity { get; set; }
    }
}
