using CommPulse.DAL.Entities;
using CommPulse.Models;
using CommPulse.Models.Outputs;
using System.ComponentModel.DataAnnotations;

namespace CommPulse.Models.Inputs
{
    /// <summary>
    /// Класс для передачи данных о канале между клиентом и сервером
    /// </summary>
    public class ChannelInputModel
    {
        [Required(ErrorMessage = "Название канала обязательно")]
        [MaxLength(35, ErrorMessage = "Длина строки названия канала не может превышать 35 символов")] //Проверка на длину названия канала
        public string Name { get; set; }

        [MaxLength(150, ErrorMessage = "Длина строки описания канала не может превышать 150 символов")] //Проверка на длину описания канала
        public string? Description { get; set; }

        [Required(ErrorMessage = "Создатель канала обязателен")]
        public Guid Creator { get; set; }  // Идентификатор пользователя, создающего канал

    }
}
