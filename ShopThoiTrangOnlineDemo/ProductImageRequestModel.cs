namespace ShopThoiTrangOnlineDemo
{
    public class ProductImageRequestModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string? Image { get; set; }
        public bool IsDefault { get; set; }
    }
}
