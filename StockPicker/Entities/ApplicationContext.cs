using Microsoft.EntityFrameworkCore;

namespace StockPicker.Entities
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options): base(options) { }

        public DbSet<Stock> Stocks { get; set; }
    }
}
