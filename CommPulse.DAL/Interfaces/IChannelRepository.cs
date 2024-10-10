using CommPulse.DAL.Entities;

namespace CommPulse.DAL.Interfaces
{
    public interface IChannelRepository
    {
        Task<List<Channel>> GetChannelsByNameAsync(string name);
    }
}
