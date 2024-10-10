using CommPulse.DAL.Entities;
using CommPulse.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CommPulse.DAL.Repositories
{
    public class ChannelRepository : IChannelRepository
    {
        private readonly MyDbContext _dbContext;

        public ChannelRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Channel>> GetChannelsByNameAsync(string name)
        {
            var result = await _dbContext.Channels
                .AsNoTracking()
                .Include(x => x.Creator)
                .Where(x => x.Name == name)
                .ToListAsync();

            return result;
        }
    }
}
