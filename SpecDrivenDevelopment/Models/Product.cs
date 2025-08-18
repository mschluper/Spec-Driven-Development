using System.ComponentModel.DataAnnotations;

namespace SpecDrivenDevelopment.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string? Description { get; set; }
        
        public decimal? Price { get; set; }
        
        public DateTime LastModifiedDate { get; set; }
        
        [Required]
        [StringLength(100)]
        public string LastModifiedBy { get; set; } = string.Empty;
        
        // Navigation properties
        public virtual ICollection<ProductStore> ProductStores { get; set; } = new List<ProductStore>();
        public virtual ICollection<ShoppingItem> ShoppingItems { get; set; } = new List<ShoppingItem>();
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
    }
}
