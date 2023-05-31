namespace WPFApplication.Domain.Models
{
    /// <summary>
    /// Represents a car engine.
    /// </summary>
    public class Engine
    {
        /// <summary>
        /// Gets the unique identifier of the engine.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Gets the engine type.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the engine capacity.
        /// </summary>
        public double Capacity { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Engine"/> class.
        /// </summary>
        /// <param name="id">The unique identifier of the engine.</param>
        /// <param name="type">The engine type.</param>
        /// <param name="capacity">The engine capacity.</param>
        public Engine(Guid id, string type, double capacity)
        {
            Id = id;
            Type = type;
            Capacity = capacity;
        }
    }
}
