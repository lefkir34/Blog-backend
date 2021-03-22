using Blog.API.ViewModels;
using Blog.API.ViewModels.Auth ;
namespace Blog.API.Services.Abstraction
{
    public interface IAuthService
    {
        string HashPassword(string password);
        bool VerifyPassword(string actualPassword, string hashedPassword);
        AuthData GetAuthData(string id);
    }
}