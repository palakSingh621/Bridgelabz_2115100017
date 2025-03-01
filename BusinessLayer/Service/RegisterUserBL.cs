using RepositoryLayer.Interface;
using ModelLayer.DTO;
using BusinessLayer.Interface;
using Microsoft.Extensions.Logging;
namespace BusinessLayer.Service
{
    public class RegisterUserBL:IRegisterUserBL
    {
        private readonly ILogger<RegisterUserBL> _logger;
        private readonly IRegisterUserRL _registerUserRL;
        public RegisterUserBL(ILogger<RegisterUserBL> logger, IRegisterUserRL registerUserRL)
        {
            _logger = logger;
            _registerUserRL = registerUserRL;
        }

        public string RegisterBL() 
        {
            return "This is Business Layer: "+_registerUserRL.RegisterRL();
        }

        public bool RegisterUser(LoginDTO newUser)
        {
            _logger.LogInformation("Business Layer: Registering user...");
            return _registerUserRL.RegisterUser(newUser);
        }

        public bool LoginUser(LoginDTO loginDTO)
        {
            LoginDTO result = _registerUserRL.GetUserByEmail(loginDTO.Email);

            if (result == null)
            {
                return false;
            }
            return CheckEmailPassword(loginDTO.Email, loginDTO.Password, result);
        }

        private bool CheckEmailPassword(string email, string password, LoginDTO result)
        {
            if (email.Equals(result.Email) && password.Equals(result.Password))
            {
                return true;
            }
            return false;
        }
    }
}
