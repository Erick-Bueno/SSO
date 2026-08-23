using Microsoft.AspNetCore.Mvc;
using OpenIddict.Abstractions;

namespace SSO.Controllers;

public class ClientController(IOpenIddictApplicationManager applicationManager) : ApiController
{
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] CreateClientRequest request)
    {
        if (applicationManager.FindByClientIdAsync(request.Id) is not null)
        {
            return Conflict("Cliente ja existe");
        }
        var clientId = new Guid().ToString();
        var clientSecret = System.Security.Cryptography.RandomNumberGenerator.GetString(
            "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_", 43);

        var descriptor = new OpenIddictApplicationDescriptor
        {
            ClientId = clientId,
            ClientSecret = clientSecret,
            RedirectUris = ,
            DisplayName = request.DisplayName,
            Permissions = 
        };
        await applicationManager.CreateAsync(
            descriptor
        );
    }
}
