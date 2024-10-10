using CommPulse.DAL.Entities;
using CommPulse.Models;
using System.ComponentModel.DataAnnotations;

namespace CommPulse.DTO
{
    /// <summary>
    /// Класс для передачи данных о канале между клиентом и сервером
    /// </summary>
    public class ChannelDTO
    {
        [MaxLength(35, ErrorMessage = "Длина строки названия канала не может превышать 35 символов")] //Проверка на длину названия канала
        public string Name { get; set; }

        [MaxLength(75, ErrorMessage = "Длина строки описания канала не может превышать 75 символов")] //Проверка на длину описания канала
        public string? Description { get; set; }

        public UserApiModel Creator { get; set; }

        public List<string> Members { get; set; }
    }
}
