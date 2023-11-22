using DoctorLife.BLL.Interface;
using DoctorLife.DL.DTO;
using DoctorLife.DL.DTO.Request;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DoctorLife.BLL
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;


        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GenerateToken(LoginRequest loginRequest, User user)
        {
            var key = Encoding.ASCII.GetBytes(_configuration.GetValue<string>("Settings:AppSecret"));

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("Name", user.Name),
                    new Claim(ClaimTypes.Email, loginRequest.Email),
                    new Claim("IsActive", user.IsActive.ToString()),
                    new Claim("Cpf", user.Cpf ?? string.Empty),
                    new Claim("BirthDay", user.BirthDay.ToString() ?? string.Empty),
                    new Claim("Crm", user.Crm ?? string.Empty),
                    new Claim("Expertise", user.Expertise ?? string.Empty),
                    new Claim(ClaimTypes.Role, loginRequest.Role.ToString()),
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
