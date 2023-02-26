using AutoMapper;
using Discount.Grpc.Protos;

namespace Discount.Grpc.Entities.Mapper
{
    public class DiscountProfile : Profile
    {
        public DiscountProfile()
        {
            CreateMap<Coupon, CouponModel>().ReverseMap();
        }
    }
}
