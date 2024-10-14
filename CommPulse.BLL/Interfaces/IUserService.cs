using CommPulse.BLL.Models;

namespace CommPulse.BLL.Interfaces
{
    public interface IUserService
    {
        Task<UserModel> GetUserByNameAsync(string name);
    }
}
