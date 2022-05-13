using AutoMapper;
using PathOrderManagement.Contract.App.Request.Cargo;
using PathOrderManagement.Contract.App.Request.Login;
using PathOrderManagement.Contract.App.Request.Order;
using PathOrderManagement.Contract.App.Response.Cargo;
using PathOrderManagement.Contract.App.Response.Order;
using PathOrderManagement.Entity.DbPathOrderManagement.Cargo;
using PathOrderManagement.Entity.DbPathOrderManagement.Order;
using PathOrderManagement.Entity.DbPathOrderManagement.User;

namespace PathOrderManagement.Contract.Mapper
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            //Login
            CreateMap<SignUpRequest, User>();

            //Order
            CreateMap<CreateOrderRequest, Order>();
            CreateMap<Order, OrderResponse>()
                .ForMember(p => p.Customer, b => b.MapFrom(p => p.Customer.Firstname + " " + p.Customer.Lastname))
                .ForMember(p => p.Category, b => b.MapFrom(p => p.Category.Name));

            //Cargo
            CreateMap<CreateCargoRequest, Cargo>();
            CreateMap<Cargo, CargoResponse>()
                .ForMember(p => p.Company, b => b.MapFrom(p => p.Company.Name))
                .ForMember(p => p.Category, b => b.MapFrom(p => p.Order.Category.Name));
        }
    }
}
