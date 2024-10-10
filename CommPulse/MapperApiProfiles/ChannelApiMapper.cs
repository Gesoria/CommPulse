using AutoMapper;
using CommPulse.BLL.Models;
using CommPulse.DTO;

namespace CommPulse.MapperApiProfiles
{
    public class ChannelApiMapper : Profile
    {
        public ChannelApiMapper() 
        {
            CreateMap<ChannelModel, ChannelDTO>()
                .ForMember(dst => dst.Creator, opt => opt
                .MapFrom(src => src.Creator.Name));

            CreateMap<ChannelDTO, ChannelModel>();

        }
    }
}
