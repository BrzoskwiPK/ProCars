namespace WPFApplication.EntityFramework.DTOs
{
    /// <summary>
    /// Data Transfer Object (DTO) for a car model.
    /// </summary>
    public class ModelDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the model.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the model.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the year of production of the model.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the manufacturer of the model.
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets the price of the model.
        /// </summary>
        public decimal Price { get; set; }
    }
}
