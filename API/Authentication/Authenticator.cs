using BLL.DTO.User;
using BLL.Interfaces;
using Core.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api.Authentication
{
    public class Authenticator
    {
        private readonly IUserService userBusinessLogic;
        private readonly IConfiguration configuration;

        public Authenticator(IUserService userBusinessLogic, IConfiguration configuration)
        {
            this.userBusinessLogic = userBusinessLogic;
            this.configuration = configuration;
        }

        public string Authenticate(Login login)
        {
            var user = userBusinessLogic.Get(login.UserName);

            if (user == null)
            {
                throw new BadHttpRequestException("user doesn't exist");
            }

            if (userBusinessLogic.IsPasswordMatch(login.Password, user.Password))
            {
                return GenerateJSONWebToken(user);
            }

            throw new Exception("user name or password is wrong");
        }

        private string GenerateJSONWebToken(UserCredentials user)
        {
            var userClaims = new List<Claim>();

            userClaims.Add(new Claim("userId", user.UserId.ToString()));

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
              configuration["Jwt:Issuer"],
              configuration["Jwt:Issuer"],
              userClaims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
