namespace WPFApplication.EntityFramework.DTOs
{
    /// <summary>
    /// Data Transfer Object (DTO) for a car engine.
    /// </summary>
    public class EngineDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the engine.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the engine type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the engine capacity.
        /// </summary>
        public double Capacity { get; set; }
    }
}
