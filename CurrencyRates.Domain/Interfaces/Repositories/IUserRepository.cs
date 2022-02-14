﻿using CurrencyRates.Domain.Models;

namespace CurrencyRates.Domain.Interfaces.Repositories
{
    public  interface IUserRepository
    {
        Task CreateUser(User user);
        Task<User?> GetUserByEmail(string email);
        Task<User?> Login(string email, string password);
    }
}
