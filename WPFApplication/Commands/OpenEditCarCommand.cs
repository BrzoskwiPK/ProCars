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
    public class OpenEditCarCommand : CommandBase
    {
        private readonly Car _car;
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenEditCarCommand(Car car, ModalNavigationStore modalNavigationStore)
        {
            _car = car;
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            EditCarViewModel editCarViewModel = new EditCarViewModel(_car, _modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = editCarViewModel;
        }
    }
}
