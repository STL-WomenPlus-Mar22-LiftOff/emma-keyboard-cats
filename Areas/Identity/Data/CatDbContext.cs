using Keyboard_Cats.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Keyboard_Cats.Data
{
    public class CatDbContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }
        
        public CatDbContext(DbContextOptions<CatDbContext> options) : base(options)
        {
        }
        public CatDbContext()
        {
        }
    }

}