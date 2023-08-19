using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Services;

namespace ShopThoiTrangOnlineDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _OrderDetailService;
        private readonly IMapper _mapper;

        public OrderDetailController(IOrderDetailService OrderDetailService, IMapper mapper)
        {
            _OrderDetailService = OrderDetailService;
            _mapper = mapper;
        }

        [HttpGet("OrderDetails")]
        public async Task<IActionResult> GetOrderDetails()
        {
            var result = await _OrderDetailService.GetOrderDetails();
            return Ok(result);
        }
        [HttpPost("OrderDetails")]

        public async Task<IActionResult> CreateOrderDetail([FromBody] OrderDetailRequestModel OrderDetail)
        {
            var mappedOrderDetail = _mapper.Map<OrderDetail>(OrderDetail);
            _OrderDetailService.CreateOrderDetail(mappedOrderDetail);
            return Ok("Created successfully");
        }
    }
}
