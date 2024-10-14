namespace CommPulse.Models.Inputs
{
    /// <summary>
    /// Класс для передачи данных пользователя между клиентом и сервером
    /// </summary>
    public class LoginInputModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
