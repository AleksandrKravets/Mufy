using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Mufy.API.Controllers
{
    [Route("api/auth")]
    public class AuthenticationController : Controller
    {
        public AuthenticationController()
        {
        }

        [Route("login")]
        public async Task<IActionResult> Login()
        {
            return Ok();
        }

        [Route("refresh")]
        public async Task<IActionResult> RefreshTokens()
        {
            return Ok();
        }
    }
}
