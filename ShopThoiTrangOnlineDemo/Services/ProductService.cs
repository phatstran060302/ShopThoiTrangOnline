using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Repositories;

namespace ShopThoiTrangOnlineDemo.Services
{
    public interface IProductService
    {
        public Task<ICollection<Product>> GetProducts();
        public Task CreateProduct(Product product);

    }
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productEntityRepository;

        public ProductService(ProductRepository productEntityRepository) 
        {
            _productEntityRepository = productEntityRepository;
        }

        public async Task CreateProduct(Product product)
        {
            await _productEntityRepository.Add(product);
            return;
        }

        public async Task<ICollection<Product>> GetProducts()
        {
            var listProduct = _productEntityRepository.GetAll();
            return listProduct.ToList();
        }
    }
}
