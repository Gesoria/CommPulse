using CommPulse.BLL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommPulse.BLL.Interfaces
{
    public interface IChannelService
    {
        Task<ChannelModel> CreateChannelAsync(ChannelModel channelModel, string creatorId);
        Task<List<ChannelModel>?> GetChannelsByNameAsync(string name);
    }

}
