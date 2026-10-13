using Microsoft.EntityFrameworkCore;
using SchoolNewspaperBlazorApp.Data;
using SchoolNewspaperBlazorApp.Interfaces.Repository;

namespace SchoolNewspaperBlazorApp.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly NewspaperDbContext _context;

        public AuthRepository(NewspaperDbContext context)
        {
            _context = context;
        }

        public async Task<User?> LoginAsync(string login, string haslo)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u =>
                    u.Login == login && u.Haslo == haslo);
        }

        public async Task<bool> RegisterAsync(User user)
        {
            bool exists = await _context.Users.AnyAsync(u =>
                u.Login == user.Login || u.Email == user.Email);

            if (exists)
            {
                return false;
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}