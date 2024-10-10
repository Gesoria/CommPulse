using AutoMapper;
using CommPulse.BLL.Models;
using CommPulse.DTO;

namespace CommPulse.MapperApiProfiles
{
    public class MessageApiMapper : Profile
    {
        public MessageApiMapper() 
        {
            CreateMap<MessageSendDTO, MessageModel>().ReverseMap();
        }
    }
}
