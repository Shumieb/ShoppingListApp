namespace ShoppingListApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool IsPicked { get; set; }
    }
}
