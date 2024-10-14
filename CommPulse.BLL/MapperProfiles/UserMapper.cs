using AutoMapper;
using CommPulse.BLL.Models;
using CommPulse.DAL.Entities;

namespace CommPulse.BLL.MapperProfiles
{
    public class UserMapper : Profile
    {
        public UserMapper() 
        {
            CreateMap<UserModel, ApplicationUser>().ReverseMap();
        }
    }
}
