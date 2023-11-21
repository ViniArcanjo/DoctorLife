using DoctorLife.BLL.Interface;
using DoctorLife.DL.Base;
using DoctorLife.DL.DTO.Request;
using DoctorLife.DL.Enums;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel;
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

        public string GenerateToken(LoginRequest loginRequest)
        {
            var key = Encoding.ASCII.GetBytes(_configuration.GetValue<string>("Settings:AppSecret"));

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, loginRequest.Email),
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
