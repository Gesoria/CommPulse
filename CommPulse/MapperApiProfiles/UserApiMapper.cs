using AutoMapper;
using CommPulse.BLL.Models;
using CommPulse.Models;

namespace CommPulse.MapperApiProfiles
{
    public class UserApiMapper : Profile
    {
        public UserApiMapper() 
        {
            CreateMap<UserApiModel,UserModel>().ReverseMap();
        }
    }
}
