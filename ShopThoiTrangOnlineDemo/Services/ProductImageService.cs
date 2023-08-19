using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Repositories;

namespace ShopThoiTrangOnlineDemo.Services
{
    public interface IProductImageService
    {
        public Task<ICollection<ProductImage>> GetProductImages();
        public Task CreateProductImage(ProductImage ProductImage);
    }
    public class ProductImageService : IProductImageService
    {
        private readonly ProductImageRepository _ProductImageRepository;

        public ProductImageService(ProductImageRepository ProductImageRepository)

        {
            _ProductImageRepository = ProductImageRepository;
        }

        public async Task CreateProductImage(ProductImage ProductImage)
        {
            await _ProductImageRepository.Add(ProductImage);
            return;
        }

        public async Task<ICollection<ProductImage>> GetProductImages()
        {
            var listProductImage = _ProductImageRepository.GetAll();
            return listProductImage.ToList();
        }
    }
}
