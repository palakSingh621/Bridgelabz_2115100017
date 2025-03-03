using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;

namespace UserRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationSystemController : ControllerBase
    {
        private readonly ILogger<UserRegistrationSystemController> _logger; 
        private readonly IRegisterUserBL _resgisteruserBL;
        ResponseModel<string> response;

        public UserRegistrationSystemController(ILogger<UserRegistrationSystemController> logger,IRegisterUserBL registerUserBL)
        {
            _logger = logger;
            _resgisteruserBL = registerUserBL;
        }

        [HttpGet]
        public string Get()
        {
            return "This is Controller: "+_resgisteruserBL.RegisterBL();
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(RegisterDTO newUser)
        {
            _logger.LogInformation("Register method called.");
            try
            {
                response = new ResponseModel<string>();
                bool isRegistered = _resgisteruserBL.RegisterUser(newUser);
                if (isRegistered)
                {
                    response.Success = true;
                    response.Message = "User Registered Successfully!";
                    response.Data = newUser.ToString();
                    _logger.LogInformation("User Registered successfully.");
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "User with this email already exists!";
                _logger.LogWarning("User registration failed: Email already exists.");
                return Conflict(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occuredwhile registring user.");
                return StatusCode(500, "Internal Server Error");
            }
        }   

        [HttpPost("login")]
        public IActionResult Login(LoginDTO loginDTO)
        {
            try
            {
                response = new ResponseModel<string>();
                bool result = _resgisteruserBL.LoginUser(loginDTO);
                if (result)
                {
                    response.Success = true;
                    response.Message = "Login Successfully!!";
                    response.Data = loginDTO.ToString();
                    _logger.LogInformation($"User {loginDTO.Email} logged in successfully.");
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "Login Unsuccessfully!!";
                _logger.LogWarning($"Failed login attempt for {loginDTO.Email}.");
                return Unauthorized(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during login.");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
