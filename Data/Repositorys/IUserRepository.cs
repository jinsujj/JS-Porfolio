﻿﻿using MyApp.ViewModels;

namespace MyApp.Data.Repositorys
{
    public interface IUserRepository
    {
        void AddUser(RegisterViewModel model);
        RegisterViewModel GetUserById(string userId);
        bool IsCorrectUser(string email, string password);
        void ModifyUser(RegisterViewModel model);
    }
}