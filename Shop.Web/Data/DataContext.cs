

namespace Shop.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.Data.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Product> MProducts { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
