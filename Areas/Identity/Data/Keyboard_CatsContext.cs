using Keyboard_Cats.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Keyboard_Cats.Models;


namespace Keyboard_Cats.Data;

public class Keyboard_CatsContext : IdentityDbContext<Keyboard_CatsUser>
{
    public DbSet<Cat>? Cats { get; set; }
    
    public Keyboard_CatsContext(DbContextOptions<Keyboard_CatsContext> options)
        : base(options)
    {
    }

    public Keyboard_CatsContext()
    {
    }


    /*protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Cat>()
            
            .HasKey(c => Cat.Animals.Id);
    }*/
}