

namespace Shop.Web.Helpers
{
using Microsoft.AspNetCore.Identity;
using Data.Entities;
using Models;

using System.Threading.Tasks;
 public   interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);


        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }
}
