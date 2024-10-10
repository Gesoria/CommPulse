namespace CommPulse.DTO
{
    /// <summary>
    /// Класс для передачи данных пользователя между клиентом и сервером
    /// </summary>
    public class LoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }       
    }
}
