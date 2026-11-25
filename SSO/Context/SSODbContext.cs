using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SSO.Context;

public class SSODbContext : IdentityDbContext<IdentityUser>
{
    public SSODbContext(DbContextOptions options)
        : base(options) { }

    protected SSODbContext() { }
}
