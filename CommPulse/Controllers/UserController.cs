using AutoMapper;
using CommPulse.BLL.Interfaces;
using CommPulse.DAL.Entities;
using CommPulse.Models;
using CommPulse.Models.Outputs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CommPulse.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {

        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }
        [HttpGet]
        [Route("get-user/{id}")]
        public async Task<IActionResult> GetUserByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest(new { message = "Введите имя пользователя" });
            }
            var user = await _userService.GetUserByNameAsync(name);
            if (user == null)
            {
                return BadRequest(new { message = "Пользователь не найден" });
            }
            var userApiModel = _mapper.Map<UserOutputModel>(user);
            return View(userApiModel);

        }

    }
}