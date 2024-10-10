namespace CommPulse.BLL.Models
{
    public class ChannelModel
    {
        public long Id { get; set; }
        public UserModel Creator { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<UserModel>? Members { get; set; }
    }
}
