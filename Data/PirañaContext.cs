using Microsoft.EntityFrameworkCore;
using PC2.Models;

namespace PC2.Data
{
    public class PirañaContext : DbContext
    {
        public DbSet<Piraña> pirañas { get; set; }

        public PirañaContext(DbContextOptions dco) : base(dco) {

        }
    }
}