

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
        Task<IdentityResult> UpdateUserAsync(User user);

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<SignInResult> ValidatePasswordAsync(User user, string password);
        Task CheckRoleAsync(string rolename);


        Task AddUserToRoleAsync(User user, string rolename);
        Task<bool> IsUserInRoleAsync(User user, string rolename);



        Task<string> GenerateEmailConfirmationTokenAsync(User user);

        Task<IdentityResult> ConfirmEmailAsync(User user, string token);

        Task<User> GetUserByIdAsync(string userId);


        Task<string> GeneratePasswordResetTokenAsync(User user);

        Task<IdentityResult> ResetPasswordAsync(User user, string token, string password);


    }
}
