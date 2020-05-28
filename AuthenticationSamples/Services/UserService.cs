using AuthenticationSamples.Data;
using AuthenticationSamples.Entities;
using AuthenticationSamples.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationSamples.Services
{
    public class UserService: IUserService
    {
        private DataContext _context;
      
        public UserService(
            DataContext context
            )
        {
            _context = context;
           
        }

        public async Task<User> Authenticate(string username, string password)
        {
            var user =await _context.Users.SingleOrDefaultAsync(x => x.Username == username && x.Password == password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so return user details without password
            return user.WithoutPassword();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.ToListAsync();//.WithoutPasswords();
        }
    }
}
