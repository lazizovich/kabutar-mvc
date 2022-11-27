﻿using Kabutar.Domain.Entities;

namespace Kabutar.Data.Interfaces.Users
{
    public interface IUserRepository : IGenericRepository<User>
    {
        public Task<User?> GetByEmailAsync(string email);

        public Task<User?> GetByUsernameAsync(string username);

        public Task<User?> GetByPhonNumberAsync(string phoneNumber);
    }
}
