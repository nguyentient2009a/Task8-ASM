using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Task8vs6.Models;

namespace Task8vs6.Data;

public class Task8vs6Context : IdentityDbContext<IdentityUser>
{
    public Task8vs6Context(DbContextOptions<Task8vs6Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<Task8vs6.Models.Category> Category { get; set; }

    public DbSet<Task8vs6.Models.Product> Product { get; set; }
}
