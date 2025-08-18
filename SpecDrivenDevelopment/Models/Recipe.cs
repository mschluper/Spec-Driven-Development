using System.ComponentModel.DataAnnotations;

namespace SpecDrivenDevelopment.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(1000)]
        public string? Instructions { get; set; }
        
        public DateTime LastModifiedDate { get; set; }
        
        [Required]
        [StringLength(100)]
        public string LastModifiedBy { get; set; } = string.Empty;
        
        // Navigation properties
        public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();
    }
}
