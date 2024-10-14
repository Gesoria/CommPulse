using AutoMapper;
using CommPulse.BLL.Models;
using CommPulse.Models.Inputs;

namespace CommPulse.MapperApiProfiles
{
    public class MessageApiMapper : Profile
    {
        public MessageApiMapper() 
        {
            CreateMap<MessageInputModel, MessageModel>().ReverseMap();
        }
    }
}
