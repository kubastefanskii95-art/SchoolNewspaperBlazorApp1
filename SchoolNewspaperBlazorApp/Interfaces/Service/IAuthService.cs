using SchoolNewspaperBlazorApp.Data;

namespace SchoolNewspaperBlazorApp.Interfaces.Service
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(string login, string haslo);

        Task<bool> RegisterAsync(User user);
    }
}