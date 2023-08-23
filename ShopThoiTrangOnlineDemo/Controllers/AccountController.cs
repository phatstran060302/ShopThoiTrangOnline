using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopThoiTrangOnlineDemo.Entity;
using ShopThoiTrangOnlineDemo.Services;

namespace ShopThoiTrangOnlineDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService) 
        {
            _accountService = accountService;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult>SignUp(SignUp signUp)
        {
            var result = await _accountService.SignUpAsync(signUp);
            if (result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignIn signIn)
        {
            var result = await _accountService.SingInAsync(signIn);
            if(string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            
            return Ok(result);
        }
    }
}
