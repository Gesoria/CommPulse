using AutoMapper;
using CommPulse.BLL.Interfaces;
using CommPulse.BLL.Models;
using CommPulse.DTO;
using Microsoft.AspNetCore.Mvc;

namespace CommPulse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChannelController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IChannelService _channelService;
        public ChannelController(IMapper mapper, IChannelService channelService)
        {
            _mapper = mapper;
            _channelService = channelService;
        }

        [HttpPost("create-channel")]
        public async Task<IActionResult> CreateChannel(ChannelDTO channelDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //Ошибка 400 при невалидных данных
            }

            var newChannel = _mapper.Map<ChannelModel>(channelDto);

            try
            {
                //Сохраняю новый канал в базе данных через бизнес-логику 
                //await _channelService.CreateChannel(newChannel);

                return Ok();
            }
            catch (Exception ex)
            {
                //Ошибка сервера при создании канала
                return StatusCode(500, $"Ошибка создания канала: {ex.Message}");
            }

        }

        [HttpGet("get-channel-by-name/{name}")]
        public async Task<ActionResult<List<ChannelDTO>>> GetChannelsByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Введите название канала");
            }

            var channelsModel = await _channelService.GetChannelsByNameAsync(name);

            if (channelsModel.Count != 0 || channelsModel != null)
            {
                var channelsDto = _mapper.Map<List<ChannelDTO>>(channelsModel);
                return channelsDto;
            }
            else
            {
                return BadRequest($"По запросу \"{name}\" не найдено ни одного результата");
            }

        }
    }

}
