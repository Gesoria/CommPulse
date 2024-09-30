using Microsoft.AspNetCore.Identity;

namespace CommPulse.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {      
        /// <summary>
        /// Список каналов юзера
        /// </summary>
        public List<Channel> UserChannels { get; set; } = [];

        /// <summary>
        /// Список каналов в которых состоит юзер
        /// </summary>
        public List<Channel> MemberChannels { get; set; } = [];
    }
}
