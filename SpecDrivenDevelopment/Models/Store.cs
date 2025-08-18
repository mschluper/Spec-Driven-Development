using System.ComponentModel.DataAnnotations;

namespace SpecDrivenDevelopment.Models
{
    public class Store
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string? Description { get; set; }
        
        public DateTime LastModifiedDate { get; set; }
        
        [Required]
        [StringLength(100)]
        public string LastModifiedBy { get; set; } = string.Empty;
        
        // Navigation properties for future use
        public virtual ICollection<ProductStore> ProductStores { get; set; } = new List<ProductStore>();
    }
}
