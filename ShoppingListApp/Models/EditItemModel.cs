using System.ComponentModel.DataAnnotations;

namespace ShoppingListApp.Models
{
    public class EditItemModel
    {
        [Required]
        public string Name { get; set; }
    }
}
