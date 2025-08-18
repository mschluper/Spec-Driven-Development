using System.ComponentModel.DataAnnotations;

namespace SpecDrivenDevelopment.Models
{
    public class ShoppingItem
    {
        public int Id { get; set; }
        
        public int ProductId { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        public bool IsPurchased { get; set; }
        
        public DateTime LastModifiedDate { get; set; }
        
        [Required]
        [StringLength(100)]
        public string LastModifiedBy { get; set; } = string.Empty;
        
        // Navigation properties
        public virtual Product Product { get; set; } = null!;
    }
}
