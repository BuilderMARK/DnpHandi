using System.Threading.Tasks;
using LoginExample.Models;

namespace ToDo.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string username, string password);
        Task  AddUser(User addUser);
        

    }
}