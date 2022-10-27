using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZuriTask_.Services;

namespace ZuriTask_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("Get")]
        public Model Get()
        {
            var user = _userService.Get();
            return user;
        }
    }
}
