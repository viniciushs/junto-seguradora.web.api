namespace BackEnd.API.Controllers
{
    using BackEnd.Infra.Identity.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Logging;
    using Microsoft.IdentityModel.Tokens;
    using System;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;

    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IConfiguration configuration,
            ILoggerFactory loggerFactory)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._configuration = configuration;
            this._logger = loggerFactory.CreateLogger<AuthController>();
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<ActionResult<UserToken>> Register([FromBody] UserInfo model)
        {
            var user = new ApplicationUser {
                UserName = model.Name,
                Email = model.Email
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return BuildToken(model);
            }
            else
            {
                if (result.Errors.Any())
                {
                    var error = result.Errors.First();
                    return BadRequest(error.Description);
                }

                return BadRequest("Usuário ou senha inválidos");
            }
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] UserInfo userInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(userInfo.Email, userInfo.Password,
                 isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                var authUser = await _userManager.FindByEmailAsync(userInfo.Email);
                userInfo.Name = authUser.NormalizedUserName;
                return BuildToken(userInfo);
            }
            else
            {
                return BadRequest("Email ou password incorretos.");
            }
        }

        [Authorize]
        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }

        private UserToken BuildToken(UserInfo userInfo)
        {
            var claims = new[]
            {
                new Claim("user_name", userInfo.Name),
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var secret = _configuration["JWT:Secret"];
            var expirationHours = int.Parse(_configuration["JWT:Expiration"]);
            var expiration = DateTime.UtcNow.AddHours(expirationHours);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
               issuer: null,
               audience: null,
               claims: claims,
               expires: expiration,
               signingCredentials: creds);

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        }
    }
}