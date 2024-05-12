using System.Threading.Tasks;
using Bloggit.DTOs;

namespace Bloggit.Interfaces
{
    public interface IAuthRepository
    {
        Task<bool> UserExistsByUsername(string username);
        Task<bool> UserExistsByEmail(string email);
        Task<bool> Register(RegisterDto registerDto);
        Task<LoginResponseData> Login(LoginDto loginDto);
        Task<bool> SendResetLink(string email);
        Task<bool> ChangePasswordWithToken(string token, string email, string newPassword);
        string ChangePassword(ChangePasswordDTO data);

    }
}
