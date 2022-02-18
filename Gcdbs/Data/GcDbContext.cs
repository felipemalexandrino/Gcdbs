using Gcdbs.Models;
using Microsoft.EntityFrameworkCore;

namespace Gcdbs.Data
{
    public class GcDbContext : DbContext
    {
        public GcDbContext(DbContextOptions<GcDbContext> options)
         : base(options)
        { }

        public DbSet<Montadora> Montadoras { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
    }
}
