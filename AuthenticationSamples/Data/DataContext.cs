using AuthenticationSamples.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationSamples.Data
{
    public class DataContext : DbContext
    {
       public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
