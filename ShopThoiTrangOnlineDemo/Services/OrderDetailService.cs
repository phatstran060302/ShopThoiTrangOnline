using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Repositories;

namespace ShopThoiTrangOnlineDemo.Services
{
    public interface IOrderDetailService
    {
        public Task<ICollection<OrderDetail>> GetOrderDetails();
        public Task CreateOrderDetail(OrderDetail OrderDetail);
    }
    public class OrderDetailService : IOrderDetailService
    {
        private readonly OrderDetailRepository _OrderDetailRepository;

        public OrderDetailService(OrderDetailRepository OrderDetailRepository)

        {
            _OrderDetailRepository = OrderDetailRepository;
        }

        public async Task CreateOrderDetail(OrderDetail OrderDetail)
        {
            await _OrderDetailRepository.Add(OrderDetail);
            return;
        }

        public async Task<ICollection<OrderDetail>> GetOrderDetails()
        {
            var listOrderDetail = _OrderDetailRepository.GetAll();
            return listOrderDetail.ToList();
        }
    }
}
