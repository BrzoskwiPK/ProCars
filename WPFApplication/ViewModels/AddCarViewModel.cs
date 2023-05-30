using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFApplication.ViewModels
{
    public class AddCarViewModel : ViewModelBase
    {
        public CarDetailsFormViewModel CarDetailsFormViewModel { get; }

        public AddCarViewModel()
        { 
            CarDetailsFormViewModel = new CarDetailsFormViewModel();
        }
    }
}
