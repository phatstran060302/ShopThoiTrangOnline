using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Repositories;

namespace ShopThoiTrangOnlineDemo.Services
{
    public interface IProductService
    {
        public Task<ICollection<Product>> GetProducts();
        public Task CreateProduct(Product product);
        public Task UpdateProduct(int id,Product product);
        public Task<Product> GetProductById(int id);

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

        public async Task<Product> GetProductById(int id)
        {
            return await _productEntityRepository.GetByIntId(id);
        }

        public async Task<ICollection<Product>> GetProducts()
        {
            var listProduct = _productEntityRepository.GetAll();
            return listProduct.ToList();
        }

        public async Task UpdateProduct(int id,Product product)
        {
            await _productEntityRepository.Update(id, product);
            return;
        }
    }
}
