using Microsoft.AspNetCore.Mvc;

namespace SSO.Controllers;

public class AccountsController : ApiController
{
    [HttpGet("/login")]
    public IActionResult Login(string? retunrnUrl = null)
    {
        return Content($"cheguei no login {retunrnUrl}");
    }

}