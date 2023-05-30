using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFApplication.Commands;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class AddCarViewModel : ViewModelBase
    {
        public CarDetailsFormViewModel CarDetailsFormViewModel { get; }

        public AddCarViewModel(ModalNavigationStore modalNavigationStore)
        {
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            CarDetailsFormViewModel = new CarDetailsFormViewModel(null, cancelCommand);
        }
    }
}
