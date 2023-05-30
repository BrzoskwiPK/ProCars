using Microsoft.EntityFrameworkCore;

namespace WPFApplication.EntityFramework
{
    public class CarsDbContextFactory
    {
        private readonly DbContextOptions _options;

        public CarsDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public CarsDbContext Create()
        {
            return new CarsDbContext(_options);
        }
    }
}
