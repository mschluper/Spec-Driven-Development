using System.ComponentModel.DataAnnotations;

namespace SpecDrivenDevelopment.Models
{
    public class ProductStore
    {
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        
        public DateTime LastModifiedDate { get; set; }
        
        [Required]
        [StringLength(100)]
        public string LastModifiedBy { get; set; } = string.Empty;
        
        // Navigation properties
        public virtual Product Product { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
    }
}
