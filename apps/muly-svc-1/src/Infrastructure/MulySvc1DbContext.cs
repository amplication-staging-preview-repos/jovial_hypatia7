using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MulySvc1.Infrastructure;

public class MulySvc1DbContext : IdentityDbContext<IdentityUser>
{
    public MulySvc1DbContext(DbContextOptions<MulySvc1DbContext> options)
        : base(options) { }
}
