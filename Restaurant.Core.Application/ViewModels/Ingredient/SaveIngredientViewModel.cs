using System.ComponentModel.DataAnnotations;

namespace Restaurant.Core.Application.ViewModels.Ingredient
{
    public class SaveIngredientViewModel
    {
        [Required(ErrorMessage = "El nombre del ingrediente es obligatorio.")]
        public string Name { get; set; }
    }
}
