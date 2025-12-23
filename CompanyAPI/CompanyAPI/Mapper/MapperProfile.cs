using AutoMapper;
using CompanyAPI.DTOs;
using CompanyAPI.Models;

namespace CompanyAPI.Mapper
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.EmplyeeName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Name));
            CreateMap<Order, CustomerOrderDTO>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name))
                .ForMember(dest => dest.TotalCost, opt => opt.MapFrom(src => src.Amount * src.Product.Cost));
            CreateMap<Customer, CustomerDTO>()
               .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Name))
               .ForMember(d => d.Orders, o => o.MapFrom(s => s.Orders));
            CreateMap<Order, OrderDTO>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.Name));
        }
    }
}
