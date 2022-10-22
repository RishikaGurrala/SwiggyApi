using SwiggyApi.DTO;
using SwiggyApi.Models;

namespace SwiggyApi.Core.IServices
{
    public interface IRegistrationService
    {
        string SignIn(LoginDTO loginDTO);
        string SignUp(User user);
    }
}
