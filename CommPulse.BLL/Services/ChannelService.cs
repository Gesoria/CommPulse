using AutoMapper;
using CommPulse.BLL.Interfaces;
using CommPulse.BLL.Models;
using CommPulse.DAL.Entities;
using CommPulse.DAL.Interfaces;

namespace CommPulse.BLL.Services
{
    public class ChannelService : IChannelService
    {
        private readonly IMapper _mapper;
        private readonly IChannelRepository _channelRepository;
        private readonly IApplicationUserRepository _userRepository;


        public ChannelService(IMapper mapper, IChannelRepository channelRepository, IApplicationUserRepository userRepository)
        {
            _mapper = mapper;
            _channelRepository = channelRepository;
            _userRepository = userRepository;
        }

      


        public async Task<ChannelModel> CreateChannelAsync(ChannelModel channelModel, string name)
        {
            // Проверка, не существует ли канал с таким же именем
            var existingChannel = await _channelRepository.GetChannelsByNameAsync(channelModel.Name);
            if (existingChannel != null)
            {
                throw new ArgumentException("Канал с таким именем уже существует");
            }

            // Получаем пользователя, который создаёт канал
            var creator = await _userRepository.GetUserByNameAsync(name);
            if (creator == null)
            {
                throw new ArgumentException("Создатель канала не найден");
            }

            // Маппинг DTO в модель
            var newChannel = _mapper.Map<Channel>(channelModel);
            newChannel.Creator = creator;
            newChannel.Members = new List<ApplicationUser> { creator }; // Добавляем создателя как первого участника
            //newChannel.CreatedAt = DateTime.UtcNow; // Если нужна отметка времени создания

            // Сохранение нового канала в базе данных
            var result = await _channelRepository.CreateChannelAsync(newChannel);
            var channelResult = _mapper.Map<ChannelModel>(result);
            
            return channelResult;
        }
        public async Task<List<ChannelModel>?> GetChannelsByNameAsync(string name)
        {        
            try
            {
                //Получаю список каналов из базы данных
                var channels = await _channelRepository.GetChannelsByNameAsync(name);
                var channelsModel = _mapper.Map<List<ChannelModel>>(channels);                

                return channelsModel;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка при получении каналов с именем \"{name}\". Ошибка: {ex.Message}");
                return null;
            }
        }


    }
}
