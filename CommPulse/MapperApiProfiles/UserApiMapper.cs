using AutoMapper;
using CommPulse.BLL.Models;
using CommPulse.Models.Inputs;
using CommPulse.Models.Outputs;

namespace CommPulse.MapperApiProfiles
{
    public class UserApiMapper : Profile
    {
        public UserApiMapper()
        {
            CreateMap<RegistrationInputModel, UserModel>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.LockoutEnd, opt => opt.Ignore())
                .ForMember(dest => dest.UserChannels, opt => opt.Ignore())
                .ForMember(dest => dest.MemberChannels, opt => opt.Ignore());

            CreateMap<UserModel, UserOutputModel>();
            CreateMap<UserModel, UserShortOutputModel>();
        }
    }
}
