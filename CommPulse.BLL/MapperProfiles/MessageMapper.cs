using AutoMapper;
using CommPulse.BLL.Models;
using CommPulse.DAL.Entities;

namespace CommPulse.BLL.MapperProfiles
{
    public class MessageMapper : Profile
    {
        public MessageMapper() 
        {
            CreateMap<MessageModel, Message>().ReverseMap();
        }
    }
}
