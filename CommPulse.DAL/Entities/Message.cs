namespace CommPulse.DAL.Entities
{
    public class Message
    {
        /// <summary>
        /// ID сообщения
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Отправитель соообщения
        /// </summary>
        public User Sender {  get; set; }

        /// <summary>
        /// Канал, в котором находится сообщение
        /// </summary>
        public Channel Channel { get; set; }

        /// <summary>
        /// Текст сообщеня
        /// </summary>
        public string Text { get; set; } 

        /// <summary>
        /// Вложеенные файлы в сообщение
        /// </summary>
        public List<string>? Attached {  get; set; }

        /// <summary>
        /// Время отправки сообщения
        /// </summary>
        public DateTime SendDate { get; set; }
    }
}
