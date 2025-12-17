using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using recap1217.Core.Interfaces;
using recap1217.Data.DTO;

namespace recap1217.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _service;
public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult Login(UserDTO userRequest)
        {

            if (_service.Login(userRequest.UName, userRequest.UPassword))
            {
                return Ok("User login ok. Here is login credentials");
            } else
            {
                return Unauthorized("Invalid username or password");
            }
                
        }

    }
}
