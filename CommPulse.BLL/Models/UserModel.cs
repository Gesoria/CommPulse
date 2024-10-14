namespace CommPulse.BLL.Models
{
    public class UserModel
    {     
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
        public List<ChannelModel> UserChannels { get; set; } = [];       
        public List<ChannelModel> MemberChannels { get; set; } = [];
    }
}
