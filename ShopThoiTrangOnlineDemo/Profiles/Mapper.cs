using AutoMapper;
using ShopThoiTrangOnlineDemo.Entity;

namespace ShopThoiTrangOnlineDemo.Profiles
{
    public class Mapper : Profile
    {
        public Mapper() 
        {
            CreateMap<Product, ProductRequestModel>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryRequestModel>().ReverseMap();
            CreateMap<Order, OrderRequestModel>().ReverseMap();
            CreateMap<ProductImage, ProductImageRequestModel>().ReverseMap();
            CreateMap<OrderDetail, OrderDetailRequestModel>().ReverseMap();
        }
    }
}
