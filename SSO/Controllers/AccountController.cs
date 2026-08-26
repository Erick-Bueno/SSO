using Microsoft.AspNetCore.Mvc;

namespace SSO.Controllers;

public class AccountController : ApiController
{
    [HttpGet("/login")]
    public IActionResult Login()
    {
        return Content($"cheguei no login");
    }

}