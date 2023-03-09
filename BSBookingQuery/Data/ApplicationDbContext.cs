using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BSBookingQuery.Models;

namespace BSBookingQuery.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BSBookingQuery.Models.Hotel> Hotel { get; set; }
        public DbSet<BSBookingQuery.Models.Comment> Comment { get; set; }
    }
}