using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WPFApplication.EntityFramework
{
    public class CarsDesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarsDbContext>
    {
        public CarsDbContext CreateDbContext(string[] args = null)
        {
            return new CarsDbContext(new DbContextOptionsBuilder().UseSqlite("Data Source=ProCars.db").Options);
        }
    }
}
