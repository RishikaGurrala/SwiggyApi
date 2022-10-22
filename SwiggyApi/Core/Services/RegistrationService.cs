using SwiggyApi.Core.IServices;
using SwiggyApi.DTO;
using SwiggyApi.Models;

namespace SwiggyApi.Core.Services
{
    public class RegistrationService:IRegistrationService
    {
        private readonly SwiggyContext Model;
        public RegistrationService(SwiggyContext swiggyContext)
        {
            Model = swiggyContext;
        }
        public string SignIn(LoginDTO loginDTO)
        {
            try
            {
                var login = Model.Users.FirstOrDefault(x => x.UserName == loginDTO.UserName && x.Password == loginDTO.Password);
                if (login != null)
                {
                    return "Login Succefull";
                }
                else
                {
                    return "Login Failed";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string SignUp(User user)
        {
            try
            {
                if (user != null)
                {
                    Model.Users.Add(user);
                    Model.SaveChanges();
                    return "registered successfully";
                }
                else
                {
                    return "registration failed";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
