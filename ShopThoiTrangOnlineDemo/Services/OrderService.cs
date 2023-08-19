using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Repositories;

namespace ShopThoiTrangOnlineDemo.Services
{
    public interface IOrderService
    {
        public Task<ICollection<Order>> GetOrders();
        public Task CreateOrder(Order Order);
    }
    public class OrderService : IOrderService
    {
        private readonly OrderRepository _OrderRepository;

        public OrderService(OrderRepository OrderRepository)

        {
            _OrderRepository = OrderRepository;
        }

        public async Task CreateOrder(Order Order)
        {
            await _OrderRepository.Add(Order);
            return;
        }

        public async Task<ICollection<Order>> GetOrders()
        {
            var listOrder = _OrderRepository.GetAll();
            return listOrder.ToList();
        }
    }
}
