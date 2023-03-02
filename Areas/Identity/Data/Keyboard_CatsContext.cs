using Keyboard_Cats.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Keyboard_Cats.Models;


namespace Keyboard_Cats.Data;

public class Keyboard_CatsContext : IdentityDbContext<Keyboard_CatsUser>
{
    public DbSet<Cat> Cats { get; set; }
    public DbSet<Cat> Animals { get; set; } //i'm just trying any name for our list...
    public DbSet<Cat> AnimalsList { get; set; } //to get controller method to recognize cat properties
    public Keyboard_CatsContext(DbContextOptions<Keyboard_CatsContext> options)
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
}