using Restaurant.Core.Application.ViewModels.OrderDishes;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Application.ViewModels.Order
{
    public class SaveOrderViewModel
    {
        [Required(ErrorMessage = "El ID de la mesa es obligatorio.")]
        public int TableId { get; set; }

        [Required(ErrorMessage = "La lista de platos es obligatoria.")]
        [MinLength(1, ErrorMessage = "Debe haber al menos un plato en la orden.")]
        public List<SaveOrderDishViewModel> OrderDishes { get; set; } = new List<SaveOrderDishViewModel>();
    }
}
