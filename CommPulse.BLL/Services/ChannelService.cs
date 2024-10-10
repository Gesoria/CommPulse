using AutoMapper;
using CommPulse.BLL.Interfaces;
using CommPulse.BLL.Models;
using CommPulse.DAL.Interfaces;

namespace CommPulse.BLL.Services
{
    public class ChannelService : IChannelService
    {
        private readonly IMapper _mapper;
        private readonly IChannelRepository _channelRepository;
        //private readonly IUserService _userService;
        

        public ChannelService(IMapper mapper, IChannelRepository channelRepository)
        {
            _mapper = mapper;
            _channelRepository = channelRepository;
        }

        public Task<ChannelModel> CreateChannelAsync(ChannelModel channelModel, string creatorId)
        {
            throw new NotImplementedException();
        }


        //public async Task<ChannelModel> CreateChannelAsync(ChannelModel channelModel, string creatorId)
        //{
        //    // Проверка, не существует ли канал с таким же именем
        //    var existingChannel = await _channelRepository.GetChannelByNameAsync(channelDto.Name);
        //    if (existingChannel != null)
        //    {
        //        throw new ArgumentException("Канал с таким именем уже существует");
        //    }

        //    // Получаем пользователя, который создаёт канаЫл
        //    var creator = await _userService.GetUserByIdAsync(creatorId);
        //    if (creator == null)
        //    {
        //        throw new ArgumentException("Создатель канала не найден");
        //    }

        //    // Маппинг DTO в модель
        //    var newChannel = _mapper.Map<ChannelModel>(channelDto);
        //    newChannel.Creator = creator;
        //    newChannel.Members = new List<ApplicationUser> { creator }; // Добавляем создателя как первого участника
        //    newChannel.CreatedAt = DateTime.UtcNow; // Если нужна отметка времени создания

        //    // Сохранение нового канала в базе данных
        //    await _channelRepository.CreateAsync(newChannel);

        //    return newChannel;
        //}
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
