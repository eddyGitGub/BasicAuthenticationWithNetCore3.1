using AuthenticationSamples.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AuthenticationSamples.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();
    }
}