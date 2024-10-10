namespace CommPulse.BLL.Models
{
    public class MessageModel
    {
        public Guid Id { get; set; }
        public UserModel Sender { get; set; }
        public ChannelModel Channel { get; set; }
        public string Text { get; set; }
        public List<string>? Attached { get; set; }
        public DateTime SendDate { get; set; }
    }
}
