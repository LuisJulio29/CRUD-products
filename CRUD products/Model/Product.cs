using System.ComponentModel.DataAnnotations;

namespace CRUD_products.Model
{
    public class Product
    {
        public int Id { get; set; }
        public required string  Name { get; set; }
        public string? Description { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Stock can´t be negative ")] public int Stock { get; set; }
    }
}
