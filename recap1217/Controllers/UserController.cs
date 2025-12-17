using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using recap1217.Core.Interfaces;
using recap1217.Data.DTO;
using recap1217.Data.Models;

namespace recap1217.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _service;
        private readonly IMapper _mapper;
public UserController(IUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult Login(UserDTO userRequest)
        {
            //This maps a DTO class with a data model class. its used because we dont want to expose our data model directly to the client and thats why we map it to a DTO.
            User user = _mapper.Map<User>(userRequest);

            // A controller should only contain code related to handling HTTP requests and responses.
            // It should delegate business logic to services.

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
