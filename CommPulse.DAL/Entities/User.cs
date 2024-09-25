namespace CommPulse.DAL.Entities
{
    public class User
    {
        /// <summary>
        /// ID пользователя
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Уникальный логин для альтернативного входа в систему
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Никнейм, под которым пользователь совершать действия
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// Адрес для рассылок(?) и верификации(?)
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Пароль для входа в систему 
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Список каналов юзера
        /// </summary>
        public List<Channel> UserChannels { get; set; } = [];

        /// <summary>
        /// Список каналов в которых состоит юзер
        /// </summary>
        public List<Channel> MemberChannels { get; set; } = [];

    }
}
