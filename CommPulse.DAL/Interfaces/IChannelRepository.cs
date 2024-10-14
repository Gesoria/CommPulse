using CommPulse.DAL.Entities;

namespace CommPulse.DAL.Interfaces
{
    public interface IChannelRepository
    {
        Task<Channel> CreateChannelAsync(Channel channel);
        Task<List<Channel>> GetChannelsByNameAsync(string name);
    }
}
