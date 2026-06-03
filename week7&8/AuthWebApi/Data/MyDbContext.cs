using AuthWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthWebApi.Data
{
    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
