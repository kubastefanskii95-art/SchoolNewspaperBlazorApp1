using SchoolNewspaperBlazorApp.Data;
using SchoolNewspaperBlazorApp.Interfaces.Repository;
using SchoolNewspaperBlazorApp.Interfaces.Service;

namespace SchoolNewspaperBlazorApp.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<User?> LoginAsync(string login, string haslo)
        {
            return await _authRepository.LoginAsync(login, haslo);
        }

        public async Task<bool> RegisterAsync(User user)
        {
            return await _authRepository.RegisterAsync(user);
        }
    }
}