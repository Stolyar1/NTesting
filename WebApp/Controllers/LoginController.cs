using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DAL.Context.dbContext;
using DAL.Interfaces;
using DAL.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly IConfiguration _config;
        private readonly PersonlRepository _repository;

        private Cript wrapper = new Cript("Ключ");

        public LoginController(IConfiguration config, PersonlRepository repository)
        {
            _config = config;
            _repository = repository;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] User login)
        {
            IActionResult response = Unauthorized();
            User user = AuthenticateUser(login);
            if (user != null)
            {
                var tokenString = GenerateJWT(user);
                response = Ok(new
                {
                    token = tokenString,
                    userDetails = user,
                });
            }
            return response;
        }

        User AuthenticateUser(User loginCredentials)
        {
            try
            {
                string pass = wrapper.EncryptData(loginCredentials.Password);
                //string passdec = wrapper.DecryptData(loginCredentials.Password);

                User user = new User();
                             
                
                var UserDb = _repository.Find(p => p.EMail == loginCredentials.UserName && p.GenPass == pass).FirstOrDefault();
                if (UserDb != null)
                {
                    user.Password = UserDb.GenPass;
                    user.UserName = UserDb.EMail;
                    user.FirstName = UserDb.EMail;
                    user.UserType = UserDb.Роли;
                    return user;

                }
                return null;

                
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Создание токена. Формирование данных для полезной нагрузки токена.
        /// </summary>
        /// <returns></returns>
        string GenerateJWT(User userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            //Данные о пользователе(UserName, role) для полезной нагрузки token
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
                new Claim("firstName", userInfo.FirstName.ToString()),
                new Claim("role",userInfo.UserType),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
