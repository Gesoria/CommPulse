namespace CommPulse.Models.Outputs
{
    public class MessageOutputModel
    {
        public Guid Id { get; set; }
        public string Content  { get; set; }
        public DateTime Timestamp { get; set; }       
        public string SenderName { get; set; }  
        public int ChannelId { get; set; }
        public List<string>? Attached { get; set; }
    }
}

