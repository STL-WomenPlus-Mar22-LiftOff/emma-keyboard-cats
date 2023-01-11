using Microsoft.EntityFrameworkCore;

namespace Keyboard_Cats.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
    }
}
