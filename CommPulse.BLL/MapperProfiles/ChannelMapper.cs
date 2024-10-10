using AutoMapper;
using CommPulse.BLL.Models;
using CommPulse.DAL.Entities;

namespace CommPulse.BLL.MapperProfiles
{
    public class ChannelMapper : Profile
    {
        public ChannelMapper()
        {
            CreateMap<ChannelModel, Channel>().ForMember(dst => dst.Creator, opt => opt.MapFrom(src => src.Creator));
            CreateMap<Channel, ChannelModel>().ForMember(dst => dst.Creator, opt => opt.MapFrom(src => src.Creator));

            CreateMap<UserModel, ApplicationUser>()
                .ForMember(dst => dst.UserName, opt => opt.MapFrom(src => src.Name));
            CreateMap<ApplicationUser, UserModel>()
                .ForMember(dst => dst.Name, opt => opt.MapFrom(src => src.UserName));
        }
    }
}