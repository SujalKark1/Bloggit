using Bloggit.DTOs;
using Bloggit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using static Bloggit.Repository.UserRepository;

namespace Bloggit.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserDto>> GetUsers();
        Task<UserDto> GetUserById(int id);
        UserProfile GetUserProfile(int userId);
        string UpdateUserProfile(UpdateUserProfileDTO data);
        string DeleteUserProfile(int userid);


        string CreateUser(UserData data);
        string UpdateUser(UpdateUserData data);
    }
}
