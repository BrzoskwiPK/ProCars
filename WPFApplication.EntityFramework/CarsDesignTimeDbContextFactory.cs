using Microsoft.EntityFrameworkCore;

namespace WPFApplication.EntityFramework
{
    /// <summary>
    /// Represents a factory for creating instances of the <see cref="CarsDbContext"/>.
    /// </summary>
    public class CarsDbContextFactory
    {
        private readonly DbContextOptions _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarsDbContextFactory"/> class with the specified options.
        /// </summary>
        /// <param name="options">The options to be used for creating the <see cref="CarsDbContext"/>.</param>
        public CarsDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CarsDbContext"/>.
        /// </summary>
        /// <returns>A new instance of the <see cref="CarsDbContext"/>.</returns>
        public CarsDbContext Create()
        {
            return new CarsDbContext(_options);
        }
    }
}
