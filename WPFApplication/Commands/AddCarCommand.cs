using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApplication.Models;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    public class AddCarCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public AddCarCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }
        public override async Task ExecuteAsync(object? parameterr)
        {

            _modalNavigationStore.Close();
        }
    }
}
