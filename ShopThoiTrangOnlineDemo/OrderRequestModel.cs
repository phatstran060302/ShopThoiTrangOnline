using System.ComponentModel.DataAnnotations;

namespace ShopThoiTrangOnlineDemo
{
    public class OrderRequestModel
    {

        public int Id { get; set; }
        [Required]
        public string? Code { get; set; }
        [Required(ErrorMessage = "Tên khách hàng không để trống")]
        public string? CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không để trống")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không để trống")]
        public string? Adress { get; set; }
        public string? Email { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
        public int TypePayment { get; set; }
    }
}
