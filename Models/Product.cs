using System.ComponentModel.DataAnnotations;

namespace ProductsManager.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, double.MaxValue,ErrorMessage ="The price must be positive")]
        public decimal Price { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "The stock quantity must be positive")]
        public int Stock { get; set; }
        public string Category { get; set; }

        
    }
}
