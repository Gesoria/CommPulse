using CommPulse.DAL.Entities;
using CommPulse.DTO;
using CommPulse.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CommPulse.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : Controller
{

    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly IConfiguration _configuration;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _configuration = configuration;
    }

    [HttpPost]
    [Route("registration")]
    public async Task<ActionResult> RegistrationAsync(UserApiModel userModel)
    {
        var user = new ApplicationUser
        {
            UserName = userModel.Name,
            Email = userModel.Email,
            PasswordHash = userModel.Password,
            PhoneNumber = userModel.PhoneNumber

        };
        var result = await _userManager.CreateAsync(user, userModel.Password);
              


        return Ok(result);
    }

    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync(LoginDTO loginDto)
    {
        // Поиск пользователя по имени
        var user = await _userManager.FindByNameAsync(loginDto.Username);
        if (user == null)
        {
            return BadRequest(new { message = "Неправильный логин или пароль" });
        }

        // Проверка пароля пользователя
        var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
        if (!result.Succeeded)
        {
            return Unauthorized(new { message = "Неправильный логин или пароль" });
        }

        // JWT токен
        var token = GenerateJwtToken(user);

        return Ok(new { token });
    }

    /// <summary>
    /// Метод ля создания JWTтокена с конфигурациями
    /// </summary> 
    private string GenerateJwtToken(ApplicationUser user)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        { 
            new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }


}

