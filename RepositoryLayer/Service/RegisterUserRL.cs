using ModelLayer.DTO;
namespace RepositoryLayer.Service
{
    public class RegisterUserRL
    {
        private List<LoginDTO> users=new List<LoginDTO>();    
        public RegisterUserRL() {}
        public string RegisterRL()
        {
            return "This is Repository layer";
        }

        public bool RegisterUser(LoginDTO newUser)
        {
            if(users.Any(user => user.Email == newUser.Email))
            {
                return false;
            }
            users.Add(newUser);
            return true;
        }
        public LoginDTO GetUserByEmail(string email)
        { 
            return users.FirstOrDefault(user => user.Email ==email);
        }
    }
}
