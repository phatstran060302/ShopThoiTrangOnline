﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopThoiTrangOnlineDemo.Entity
{
    [Table("tb_ProductEntity")]
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string? Title { get; set; }
        [StringLength(250)]
        public string? Alias { get; set; }
        [StringLength(50)]
        public string? ProductCode { get; set; }
        public string? Description { get; set; }
        
        public string? Detail { get; set; }
        [StringLength(250)]
        public string? Image { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public decimal? PriceSale { get; set; }
        public int Quantity { get; set; }
        public int ViewCount { get; set; }
        public bool IsHome { get; set; }
        public bool IsSale { get; set; }
        public bool IsFeature { get; set; }
        public bool IsHot { get; set; }
        public bool IsActive { get; set; }
        public int ProductCategoryID { get; set; }
        [StringLength(250)]
        public string? SeoTitle { get; set; }
        [StringLength(550)]
        public string? SeoGhiChu { get; set; }
        [StringLength(250)]
        public string? SeoKeywords { get; set; }
        public virtual ProductCategory? ProductCategory { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
