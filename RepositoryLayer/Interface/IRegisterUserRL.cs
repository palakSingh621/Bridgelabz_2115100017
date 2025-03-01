using ModelLayer.DTO;

namespace RepositoryLayer.Interface
{
    public interface IRegisterUserRL
    {
        string RegisterRL();
        bool RegisterUser(LoginDTO newUser);
        LoginDTO GetUserByEmail(string email);
    }
}
