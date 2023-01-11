﻿using Keyboard_Cats.Areas.Identity.Data;
using Keyboard_Cats.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Keyboard_Cats.Data;

public class Keyboard_CatsContext : IdentityDbContext<Keyboard_CatsUser>
{
    public DbSet<User> Users { get; set; }

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
