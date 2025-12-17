using AutoMapper;

namespace recap1217.Data.Profiles
{
    public class UserProfile : Profile
    {

        public UserProfile()
        {
            CreateMap<DTO.UserDTO, Models.User>()
                .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.UName))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.UPassword));

        }
    }
}
