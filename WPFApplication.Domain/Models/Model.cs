namespace WPFApplication.Domain.Models
{
    /// <summary>
    /// Represents a car model.
    /// </summary>
    public class Model
    {
        /// <summary>
        /// Gets the unique identifier of the model.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the name of the model.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the year of production of the model.
        /// </summary>
        public int Year { get; }

        /// <summary>
        /// Gets the manufacturer of the model.
        /// </summary>
        public string Manufacturer { get; }

        /// <summary>
        /// Gets the price of the model.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model"/> class.
        /// </summary>
        /// <param name="id">The unique identifier of the model.</param>
        /// <param name="name">The name of the model.</param>
        /// <param name="year">The year of production of the model.</param>
        /// <param name="manufacturer">The manufacturer of the model.</param>
        /// <param name="price">The price of the model.</param>
        public Model(Guid id, string name, int year, string manufacturer, decimal price)
        {
            Id = id;
            Name = name;
            Year = year;
            Manufacturer = manufacturer;
            Price = price;
        }
    }
}
