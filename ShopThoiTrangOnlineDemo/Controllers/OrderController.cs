using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Services;

namespace ShopThoiTrangOnlineDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet("orders")]
        public async Task<IActionResult> GetOrders()
        {
            var result = await _orderService.GetOrders();
            return Ok(result);
        }
        [HttpPost("orders")]
        [Authorize]
        public async Task<IActionResult> CreateOrder([FromBody] OrderRequestModel order)
        {
            var mappedOrder = _mapper.Map<Order>(order);
            _orderService.CreateOrder(mappedOrder);
            return Ok("Created successfully");
        }
    }
}
