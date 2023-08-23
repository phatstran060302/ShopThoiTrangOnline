using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Services;
namespace ShopThoiTrangOnlineDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper) 
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetProducts()
        {
            var result = await _productService.GetProducts();
            return Ok(result);
        }
        [HttpPost("products")]

        public async Task<IActionResult> CreateProduct([FromBody]ProductRequestModel product)
        {
            var mappedProduct = _mapper.Map<Product>(product);
            _productService.CreateProduct(mappedProduct);
            return Ok("Created successfully");
        }

        [HttpPut("products")]
        public async Task<IActionResult> UpdateProduct(int id,[FromBody] ProductRequestModel updateProduct)
        {
            
            var mappedProduct = _mapper.Map<Product>(updateProduct);
            _productService.GetProductById(mappedProduct.Id);
            return Ok("Update successfully");
        }
    }
}
