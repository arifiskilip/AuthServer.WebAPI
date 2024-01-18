using AuthServer.Core.Dtos;
using AuthServer.Core.Models;
using AutoMapper;

namespace AuthServer.Service.Mappings
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<AppUser, AppUserDto>().ReverseMap();  
        }
    }
}
