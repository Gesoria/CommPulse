using System.ComponentModel.DataAnnotations;

namespace CommPulse.DTO
{
    /// <summary>
    /// Класс для передачи данных о сообщении между клиентом и сервером
    /// </summary>
    public class MessageSendDTO
    {      
        public string Sender { get; set; }  

        public long ChannelId { get; set; }

        [MaxLength(750, ErrorMessage = "Максимальное количество символов в сообщении - 750")] //Проверка на длину сообщения
        public string Text { get; set; }

        [MaxLength(10, ErrorMessage = "Максимальное количество вложений - 10")] //Проверка на максимальное количество вложений
        public List<string>? Attached { get; set; }       
    }
}
