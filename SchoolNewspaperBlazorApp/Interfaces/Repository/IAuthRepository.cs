using SchoolNewspaperBlazorApp.Data;

namespace SchoolNewspaperBlazorApp.Interfaces.Repository
{
    public interface IAuthRepository
    {
        Task<User?> LoginAsync(string login, string haslo);

        Task<bool> RegisterAsync(User user);
    }
}