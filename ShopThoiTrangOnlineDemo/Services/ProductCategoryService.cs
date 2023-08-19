using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Repositories;

namespace ShopThoiTrangOnlineDemo.Services
{
    public interface IProductCategoryService
    {
        public Task<ICollection<ProductCategory>> GetProductCategories();
        public Task CreateProductCategory(ProductCategory productCategory);
    }
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly ProductCategoryRepository _productCategoryRepository;

        public ProductCategoryService(ProductCategoryRepository productCategoryRepository)

        {
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task CreateProductCategory(ProductCategory productCategory)
        {
            await _productCategoryRepository.Add(productCategory);
            return;
        }

        public async Task<ICollection<ProductCategory>> GetProductCategories()
        {
            var listProductCategory = _productCategoryRepository.GetAll();
            return listProductCategory.ToList();
        }
    }
}
