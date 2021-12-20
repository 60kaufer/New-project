using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        // Navn på den <Domain> fil der refereres til og derefter det tabelnavn man vil have det skal have.
        public DbSet<Activity> Activities { get; set; }
    }
}