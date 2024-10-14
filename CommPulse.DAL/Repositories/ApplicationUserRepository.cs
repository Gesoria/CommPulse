using CommPulse.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CommPulse.DAL.Repositories
{
    public class ApplicationUserRepository
    {
        private readonly MyDbContext _dbContext;
        public ApplicationUserRepository(MyDbContext context)
        {
            _dbContext = context;
        }

        public async Task<ApplicationUser> GetUserByNameAsync(string name)
        {
            var result = await _dbContext.Users
                .AsNoTracking()
                .Include(x => x.UserChannels)
                .FirstOrDefaultAsync(x => x.UserName == name);
            return result;
        }
    }
}
