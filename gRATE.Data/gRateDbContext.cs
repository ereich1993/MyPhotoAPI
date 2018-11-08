using gRATE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace gRATE.Data
{
    public class GRateDbContext : DbContext
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }

        public GRateDbContext(DbContextOptions<GRateDbContext> options) : base(options)
        {
        }
    }
}