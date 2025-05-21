using Microsoft.EntityFrameworkCore;
using MvcAWSSeriesPractica.Models;

namespace MvcAWSSeriesPractica.Data
{
    public class SeriesContext: DbContext
    {
        public SeriesContext(DbContextOptions<SeriesContext> options) : base(options) { }
        public DbSet<Serie> Series { get; set; }
    }
}
