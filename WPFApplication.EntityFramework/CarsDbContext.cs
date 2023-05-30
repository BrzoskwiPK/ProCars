using Microsoft.EntityFrameworkCore;
using WPFApplication.EntityFramework.DTOs;

namespace WPFApplication.EntityFramework
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CarDTO> Cars { get; set; }
    }
}
