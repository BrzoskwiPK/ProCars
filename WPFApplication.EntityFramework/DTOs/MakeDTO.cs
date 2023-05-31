namespace WPFApplication.EntityFramework.DTOs
{
    /// <summary>
    /// Data Transfer Object (DTO) for a car manufacturer.
    /// </summary>
    public class MakeDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier of the manufacturer.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the manufacturer.
        /// </summary>
        public string Name { get; set; }
    }
}
