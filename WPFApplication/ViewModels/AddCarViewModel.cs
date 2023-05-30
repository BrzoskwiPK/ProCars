using System.Windows.Input;
using WPFApplication.Commands;
using WPFApplication.Stores;

namespace WPFApplication.ViewModels
{
    public class AddCarViewModel : ViewModelBase
    {
        public CarDetailsFormViewModel CarDetailsFormViewModel { get; }

        public AddCarViewModel(CarsStore carsStore, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new AddCarCommand(this, carsStore, modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            CarDetailsFormViewModel = new CarDetailsFormViewModel(submitCommand, cancelCommand);
        }
    }
}
