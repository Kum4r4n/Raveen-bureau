using Microsoft.EntityFrameworkCore;
using raveenbureau.API.Entities;

namespace raveenbureau.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }

    }
}
