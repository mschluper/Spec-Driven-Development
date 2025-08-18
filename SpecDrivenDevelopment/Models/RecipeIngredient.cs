using System.ComponentModel.DataAnnotations;

namespace SpecDrivenDevelopment.Models
{
    public class RecipeIngredient
    {
        public int RecipeId { get; set; }
        public int ProductId { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        [StringLength(50)]
        public string? Unit { get; set; }
        
        public DateTime LastModifiedDate { get; set; }
        
        [Required]
        [StringLength(100)]
        public string LastModifiedBy { get; set; } = string.Empty;
        
        // Navigation properties
        public virtual Recipe Recipe { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
