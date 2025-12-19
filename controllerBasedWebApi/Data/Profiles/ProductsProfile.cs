using AutoMapper;
using controllerBasedWebApi.Data.DTOs;
using controllerBasedWebApi.Data.Models;

namespace controllerBasedWebApi.Data.Profiles
{
    public class ProductsProfile : Profile
    {

        public ProductsProfile()
        { 
            CreateMap<ProductDTO, Product>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<Product, ProductDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
        }
    }
}
