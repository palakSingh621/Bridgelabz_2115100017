using System.Collections;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;

namespace UserRegistrationSystem.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationSystemController : ControllerBase
    {
        RegisterUserBL _resgisteruserBL;
        ResponseModel<string> response;

        public UserRegistrationSystemController(RegisterUserBL registerUserBL)
        {
            _resgisteruserBL = registerUserBL;
        }

        [HttpGet]
        public string Get()
        {
            return "This is Controller: "+_resgisteruserBL.RegisterBL();
        }

        [HttpPost("register")]
        public IActionResult RegisterUser([FromBody] LoginDTO newUser)
        {
            response = new ResponseModel<string>();
            bool isRegistered = _resgisteruserBL.RegisterUser(newUser);
            if (isRegistered)
            {
                response.Success = true;
                response.Message = "User Registered Successfully!";
                response.Data = newUser.ToString();
                return Ok(response);
            }
            response.Success = false;
            response.Message = "User with this email already exists!";
            return Conflict(response);
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
                    return Ok(response);
                }
                response.Success = false;
                response.Message = "Login Unsuccessfully!!";
                response.Data = "";
                return NotFound();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = "Login Failed!";
                response.Data = ex.Message;
                return BadRequest();
            }
        }
    }
}
