using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace OptionsPatternAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly KeyVault _keyVault;
        public AccountController(IOptions<KeyVault> keyVault)
        {
            _keyVault = keyVault.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_keyVault);
        }
    }
}
