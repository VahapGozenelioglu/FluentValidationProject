using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest=>dest.Ad, opt=>opt.MapFrom(x=>x.Name))
                .ForMember(dest=>dest.Yas, opt=>opt.MapFrom(x=>x.Age));
        }
    }
}