namespace CommPulse.Models.Outputs
{
    public class ChannelOutputModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<UserShortOutputModel> Members { get; set; }
        public  UserShortOutputModel Creator { get; set; }
    }
}
