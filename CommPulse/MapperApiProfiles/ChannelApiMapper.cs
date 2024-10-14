using AutoMapper;
using CommPulse.BLL.Models;
using CommPulse.Models.Inputs;
using CommPulse.Models.Outputs;

namespace CommPulse.MapperApiProfiles
{
    public class ChannelApiMapper : Profile
    {
        public ChannelApiMapper() 
        {
            CreateMap<ChannelInputModel, ChannelModel>()
                .ForMember(dest => dest.Creator, opt => opt
                .MapFrom(src => new UserModel { Id = src.Creator}));

            CreateMap<ChannelModel, ChannelOutputModel>()
                .ForMember(dst => dst.Members, opt => opt
                .MapFrom(src => src.Members.Select(m => new UserShortOutputModel
                {
                    UserName = m.UserName,

                })))
                .ForMember(dest => dest.Creator, opt => opt
                .MapFrom(src => new UserShortOutputModel
                {
                    UserName = src.Name,
                }));

            CreateMap<ChannelModel, ChannelShortOutputModel>()
                .ForMember(dest => dest.CountOfMembers, opt => opt.MapFrom(src => src != null ? src.Members.Count : 0))
                .ForMember(dest => dest.Creator, opt => opt.MapFrom(src => src.Creator.UserName));
        }
    }
}
