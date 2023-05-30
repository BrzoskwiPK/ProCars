using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApplication.Stores;
using WPFApplication.ViewModels;

namespace WPFApplication.Commands
{
    public class OpenAddCarCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public OpenAddCarCommand(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        public override void Execute(object? parameter)
        {
            AddCarViewModel addCarViewModel = new AddCarViewModel(_modalNavigationStore);
            _modalNavigationStore.CurrentViewModel = addCarViewModel;
        }
    }
}
