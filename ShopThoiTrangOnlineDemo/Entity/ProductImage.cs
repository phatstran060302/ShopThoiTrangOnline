using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShopThoiTrangOnlineDemo.Entity
{
    [Table("tb_ProductImageEntity")]
    public class ProductImage
    {
        [Key]
        
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Image { get; set; }
        public bool IsDefault { get; set; }
        public virtual Product? Product { get; set; }
    }
}
