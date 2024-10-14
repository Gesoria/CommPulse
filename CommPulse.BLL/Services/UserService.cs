using AutoMapper;
using CommPulse.BLL.Interfaces;
using CommPulse.BLL.Models;
using CommPulse.DAL.Interfaces;

namespace CommPulse.BLL.Services
{
    
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;       
        private readonly IApplicationUserRepository _userRepository;
       
        public UserService(IMapper mapper,IApplicationUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        public async Task<UserModel?> GetUserByNameAsync(string name)
        {
            var user = await _userRepository.GetUserByNameAsync(name);
            if(user == null)
            {
                 return null;
            }
            
            var userModel = _mapper.Map<UserModel>(user);
            return userModel;
        }
    }
}
