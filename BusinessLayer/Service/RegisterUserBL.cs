using RepositoryLayer.Service;
using ModelLayer.DTO;
namespace BusinessLayer.Service
{
    public class RegisterUserBL
    {
        RegisterUserRL _registerUserRL;
        public RegisterUserBL(RegisterUserRL registerUserRL)
        {
            _registerUserRL = registerUserRL;
        }

        public string RegisterBL() 
        {
            return "This is Business Layer: "+_registerUserRL.RegisterRL();
        }

        public bool RegisterUser(LoginDTO newUser)
        {
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

        public bool CheckEmailPassword(string email, string password, LoginDTO result)
        {
            if (email.Equals(result.Email) && password.Equals(result.Password))
            {
                return true;
            }
            return false;
        }
    }
}
