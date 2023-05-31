namespace WPFApplication.Domain.Models
{
    /// <summary>
    /// Represents a car manufacturer.
    /// </summary>
    public class Make
    {
        /// <summary>
        /// Gets the unique identifier of the manufacturer.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the name of the manufacturer.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Make"/> class.
        /// </summary>
        /// <param name="id">The unique identifier of the manufacturer.</param>
        /// <param name="name">The name of the manufacturer.</param>
        public Make(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
