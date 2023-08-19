using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Services;

namespace ShopThoiTrangOnlineDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IMapper _mapper;

        public ProductCategoryController(IProductCategoryService productCategoryService, IMapper mapper)
        {
            _productCategoryService = productCategoryService;
            _mapper = mapper;
        }

        [HttpGet("productcategories")]
        public async Task<IActionResult> GetProductCategories()
        {
            var result = await _productCategoryService.GetProductCategories();
            return Ok(result);
        }
        [HttpPost("productcategories")]

        public async Task<IActionResult> CreateProductCategory([FromBody] ProductCategoryRequestModel productCategory)
        {
            var mappedProductCategory = _mapper.Map<ProductCategory>(productCategory);
            _productCategoryService.CreateProductCategory(mappedProductCategory);
            return Ok("Created successfully");
        }
    }
}
