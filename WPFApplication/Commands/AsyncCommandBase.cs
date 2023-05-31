using System;
using System.Threading.Tasks;

namespace WPFApplication.Commands
{
    /// <summary>
    /// Represents a base class for asynchronous commands.
    /// </summary>
    public abstract class AsyncCommandBase : CommandBase
    {
        public override async void Execute(object? parameter)
        {
            try
            {
                await ExecuteAsync(parameter);
            }
            catch (Exception) {
                throw;
            }
        }

        /// <summary>
        /// Executes the command asynchronously.
        /// </summary>
        /// <param name="parameterr">The parameter for the command.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public abstract Task ExecuteAsync(object? parameterr);
    }
}
