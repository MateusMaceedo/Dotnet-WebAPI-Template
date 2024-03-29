﻿using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Models;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Domain.Services
{
    public class SecurityService : ISecurityService
    {
        public Task<Response<bool>> ComparePassword(string password, string confirmPassword)
        {
            var isEquals = password.Trim().Equals(confirmPassword.Trim());

            return Task.FromResult(Response.OK<bool>(isEquals));
        }

        public Task<Response<string>> EncryptPassword(string password)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            return Task.FromResult(Response.OK<string>(passwordHash));
        }

        public Task<Response<bool>> VerifyPassword(string password, UserModel user)
        {
            bool validPassword = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

            return Task.FromResult(Response.OK<bool>(validPassword));
        }
    }
}
