using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WPFApplication.EntityFramework
{
    /// <summary>
    /// Represents a factory for creating the database context during design time.
    /// </summary>
    public class CarsDesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarsDbContext>
    {
        /// <summary>
        /// Creates a new instance of the <see cref="CarsDbContext"/> during design time.
        /// </summary>
        /// <param name="args">The command-line arguments passed to the application.</param>
        /// <returns>A new instance of the <see cref="CarsDbContext"/>.</returns>
        public CarsDbContext CreateDbContext(string[] args = null)
        {
            return new CarsDbContext(new DbContextOptionsBuilder().UseSqlite("Data Source=ProCars.db").Options);
        }
    }

}
