using bemusic.Models;
using bemusic.Services;
using Microsoft.AspNetCore.Mvc;

namespace bemusic.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountControlller : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountControlller(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("register")]
        public ActionResult RegisterUser([FromBody]RegisterUserDto dto)
        {
            _accountService.RegisterUser(dto);
            return Ok();
        }

        [HttpPost("login")]
        public ActionResult Login([FromBody]LoginDto dto)
        {
            string token = _accountService.GenerateJwt(dto);
            return Ok(token);
        }
    }
}
