using Microsoft.Extensions.Logging;
using ModelLayer.DTO;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
namespace RepositoryLayer.Service
{
    public class RegisterUserRL:IRegisterUserRL
    {
        private readonly ILogger<RegisterUserRL> _logger;
        private readonly UserRegistrationContext _context;
        
        public RegisterUserRL(ILogger<RegisterUserRL> logger, UserRegistrationContext context) 
        {
            _logger = logger;
            _context = context;
        }
        public string RegisterRL()
        {
            return "This is Repository layer";
        }

        public bool RegisterUser(RegisterDTO newUser)
        {
            _logger.LogInformation("Repository Layer: Saving user data to DB...");
            if (_context.Users.Any(user => user.Email == newUser.Email))
            {
                return false;
            }
            var userEntity = new UserEntity
            {
                FirstName = newUser.FirstName,
                LastName = newUser.LastName,
                Email = newUser.Email,
                Password = newUser.Password,
            };
            _context.Users.Add(userEntity);
            _context.SaveChanges();
            return true;
        }
        public LoginDTO GetUserByEmail(string email)
        { 
            var user=_context.Users.FirstOrDefault(user => user.Email == email);
            if (user == null)
            {
                return null;
            }
            return new LoginDTO
            {
                Email = user.Email,
                Password = user.Password,
            };
        }
    }
}
