using System.ComponentModel.DataAnnotations;

namespace CommPulse.Models.Inputs
{
    public class RegistrationInputModel
    {
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage = "Введите корректный e-mail адрес")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Введите корректный номер телефона")]
        public string? PhoneNumber { get; set; }

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

    }
}
