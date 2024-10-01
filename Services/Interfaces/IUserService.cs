using DataAccess.Entities;

namespace BusinessLogic.Interfaces
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(string username, string password);

        Task<User> ValidateCredentialsAsync(string username, string password);
    }
}
