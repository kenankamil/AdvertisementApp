using AutoMapper;
using Kenan.AdvertisementApp.Dtos;
using Kenan.AdvertisementApp.UI.Models;

namespace Kenan.AdvertisementApp.UI.Mappings
{
    public class AppUserCreateProfile : Profile
    {
        public AppUserCreateProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>().ReverseMap();
            CreateMap<UserCreateModel, AppUserListDto>().ReverseMap();
            CreateMap<UserCreateModel, AppUserUpdateDto>().ReverseMap();
        }
    }
}
