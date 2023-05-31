namespace WPFApplication.Domain.Models
{
    /// <summary>
    /// Represents a car.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Gets the unique identifier of the car.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the make of the car.
        /// </summary>
        public string Make { get; }

        /// <summary>
        /// Gets the model of the car.
        /// </summary>
        public string Model { get; }

        /// <summary>
        /// Gets the year of the car.
        /// </summary>
        public int Year { get; }

        /// <summary>
        /// Gets the color of the car.
        /// </summary>
        public string Color { get; }

        /// <summary>
        /// Gets the mileage of the car.
        /// </summary>
        public int Mileage { get; }

        /// <summary>
        /// Gets the engine information of the car.
        /// </summary>
        public string Engine { get; }

        /// <summary>
        /// Gets the price of the car.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="id">The unique identifier of the car.</param>
        /// <param name="make">The make of the car.</param>
        /// <param name="model">The model of the car.</param>
        /// <param name="year">The year of the car.</param>
        /// <param name="color">The color of the car.</param>
        /// <param name="mileage">The mileage of the car.</param>
        /// <param name="engine">The engine information of the car.</param>
        /// <param name="price">The price of the car.</param>
        public Car(Guid id, string make, string model, int year, string color, int mileage, string engine, decimal price)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Color = color;
            Mileage = mileage;
            Engine = engine;
            Price = price;
        }
    }
}
