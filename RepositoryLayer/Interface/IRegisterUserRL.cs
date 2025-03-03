using ModelLayer.DTO;

namespace RepositoryLayer.Interface
{
    public interface IRegisterUserRL
    {
        string RegisterRL();
        bool RegisterUser(RegisterDTO newUser);
        LoginDTO GetUserByEmail(string email);
    }
}
