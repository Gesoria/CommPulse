namespace CommPulse.Models.Outputs
{
    public class UserOutputModel
    {
        public string UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
    }
}
