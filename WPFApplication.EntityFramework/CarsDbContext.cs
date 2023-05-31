using Microsoft.EntityFrameworkCore;
using WPFApplication.EntityFramework.DTOs;

namespace WPFApplication.EntityFramework
{
    /// <summary>
    /// Represents the database context for managing car-related entities.
    /// </summary>
    public class CarsDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarsDbContext"/> class with the specified options.
        /// </summary>
        /// <param name="options">The options for configuring the context.</param>
        public CarsDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the DbSet for managing car entities.
        /// </summary>
        public DbSet<CarDTO> Cars { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for managing engine entities.
        /// </summary>
        public DbSet<EngineDTO> Engines { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for managing make entities.
        /// </summary>
        public DbSet<MakeDTO> Makes { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for managing model entities.
        /// </summary>
        public DbSet<ModelDTO> Models { get; set; }
    }

}
