using Microsoft.EntityFrameworkCore;
using MvcCoreEFComics.Models;

namespace MvcCoreEFComics.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Comic> Comics { get; set; }
    }
}
