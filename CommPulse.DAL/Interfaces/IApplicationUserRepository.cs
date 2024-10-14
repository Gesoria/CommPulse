using CommPulse.DAL.Entities;

namespace CommPulse.DAL.Interfaces
{
    public interface IApplicationUserRepository
    {
        Task<ApplicationUser> GetUserByNameAsync(string name);
    }
}
