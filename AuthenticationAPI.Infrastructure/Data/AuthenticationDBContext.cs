using AuthenticationAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace AuthenticationAPI.Infrastructure.Data
{
    public class AuthenticationDBContext(DbContextOptions<AuthenticationDBContext> options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}
