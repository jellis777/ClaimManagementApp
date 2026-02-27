using ClaimManagementAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace ClaimManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Claim> Claims { get; set; }
    }
}