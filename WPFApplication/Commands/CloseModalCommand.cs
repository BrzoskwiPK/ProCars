using WPFApplication.Stores;

namespace WPFApplication.Commands
{
    /// <summary>
    /// Represents a command for closing a modal.
    /// </summary>
    public class CloseModalCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="CloseModalCommand"/> class.
        /// </summary>
        /// <param name="modalNavigationStore">The store for modal navigation.</param>
        public CloseModalCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        /// <inheritdoc/>
        public override void Execute(object? parameter)
        {
            _modalNavigationStore.Close();
        }
    }
}
