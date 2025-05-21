using Microsoft.EntityFrameworkCore;
using MvcAWSSeriesPractica.Data;
using MvcAWSSeriesPractica.Models;

namespace MvcAWSSeriesPractica.Repositories
{
    public class RepositorySeries
    {
        public SeriesContext context;
        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        public async Task<List<Serie>> GetSeriesAsync()
        {
            return await this.context.Series.ToListAsync();
        }
    }
}
