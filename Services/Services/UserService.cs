using BusinessLogic.Interfaces;
using BusinessLogic.Utilities;
using DataAccess.Entities;
using DataAccess.Interfaces;

namespace BusinessLogic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public UserService(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<User> ValidateCredentialsAsync(string username, string password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);

            if (user == null || !_passwordHasher.VerifyHashedPassword(user.PasswordHash, password))
            {
                return null;
            }

            return user;
        }

        public async Task<User> CreateUserAsync(string username, string password)
        {
            var existingUser = await _userRepository.GetByUsernameAsync(username);
            if (existingUser != null)
            {
                throw new InvalidOperationException("Username already exists.");
            }

            var hashedPassword = _passwordHasher.HashPassword(password);

            var user = new User
            {
                Username = username,
                PasswordHash = hashedPassword,
                LastActivity = DateTime.UtcNow,
            };

            await _userRepository.AddAsync(user);

            return user;
        }
    }
}