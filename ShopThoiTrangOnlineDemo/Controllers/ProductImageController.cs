using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Services;

namespace ShopThoiTrangOnlineDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly IProductImageService _ProductImageService;
        private readonly IMapper _mapper;

        public ProductImageController(IProductImageService ProductImageService, IMapper mapper)
        {
            _ProductImageService = ProductImageService;
            _mapper = mapper;
        }

        [HttpGet("productImages")]
        public async Task<IActionResult> GetProductImages()
        {
            var result = await _ProductImageService.GetProductImages();
            return Ok(result);
        }
        [HttpPost("productImages")]

        public async Task<IActionResult> CreateProductImage([FromBody] ProductImageRequestModel ProductImage)
        {
            var mappedProductImage = _mapper.Map<ProductImage>(ProductImage);
            _ProductImageService.CreateProductImage(mappedProductImage);
            return Ok("Created successfully");
        }
    }
}
