using MegaCentralFinanceBackend.Data;
using MegaCentralFinanceBackend.Requests;
using MegaCentralFinanceBackend.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MegaCentralFinanceBackend.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public class UserController : ControllerBase
    {
        public readonly ApplicationDBContext _dbContext;
        public UserController(ApplicationDBContext dBContext) 
        {
            _dbContext = dBContext;
        }

        [Route("Login")]
        [HttpPost, AllowAnonymous]
        public UserLoginResponse Login([FromBody] UserLoginRequest request)
        {
            try
            {
                bool LoginCorrect = _dbContext.ms_user
                    .Select(x => x.user_name == request.UserName && x.password == request.Password && x.is_active == true)
                    .FirstOrDefault();

                if (!LoginCorrect) {

                    return new UserLoginResponse { LoginSuccess = LoginCorrect, Message = "Login Failed" };
                }
                else
                {
                    return new UserLoginResponse { LoginSuccess = LoginCorrect, Message = "Login Successful"};
                }
            }
            catch (Exception ex) 
            {
                return new UserLoginResponse { LoginSuccess = false, Message = ex.Message };
            }
        }
    }
}
