namespace WPFApplication.EntityFramework.DTOs
{
    /// <summary>
    /// Represents a data transfer object (DTO) for a car.
    /// </summary>
    public class CarDTO
    {
        /// <summary>
        /// Gets or sets the ID of the car.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the make of the car.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the model of the car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the year of the car.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the color of the car.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Gets or sets the mileage of the car.
        /// </summary>
        public int Mileage { get; set; }

        /// <summary>
        /// Gets or sets the engine of the car.
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Gets or sets the price of the car.
        /// </summary>
        public decimal Price { get; set; }
    }

}
