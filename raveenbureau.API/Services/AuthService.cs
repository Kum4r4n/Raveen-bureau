using Microsoft.EntityFrameworkCore;
using raveenbureau.API.Data;
using raveenbureau.API.Entities;
using raveenbureau.API.Models;

namespace raveenbureau.API.Services
{
    public class AuthService
    {

        private readonly ApplicationDbContext _dbContextl;

        public AuthService(ApplicationDbContext dbContextl)
        {
            _dbContextl = dbContextl;
        }

        public async Task<User> Login(LoginModel loginModel)
        {
            var user = await _dbContextl.Users
                .FirstOrDefaultAsync(u => u.Email == loginModel.Email);

            return user;
        }
    }
}
