using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopThoiTrangOnlineDemo.Entity
{
    [Table("tb_ProductCategoryEntity")]
    public class ProductCategory
    {
        [Key]
        
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string? Title { get; set; }
        [Required]
        [StringLength(150)]
        public string? Alias { get; set; }
        public string? Description { get; set; }
        [StringLength(250)]
        public string? Icon { get; set; }
        [StringLength(250)]
        public string? SeoTitle { get; set; }
        [StringLength(500)]
        public string? SeoGhiChu { get; set; }
        [StringLength(250)]
        public string? SeoKeywords { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
