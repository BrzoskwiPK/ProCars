using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFApplication.ViewModels
{
    public class CarDetailsFormViewModel : ViewModelBase
    {
        private string _make;
        private string _model;
        private int _year;
        private string _color;
        private int _mileage;
        private string _engine;
        private decimal _price;

        public CarDetailsFormViewModel(ICommand submitCommand, ICommand cancelCommand)
        {
            SubmitCommand = submitCommand;
            CancelCommand = cancelCommand;
        }

        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
                OnPropertyChanged(nameof(Make));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Model));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
                OnPropertyChanged(nameof(Year));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                OnPropertyChanged(nameof(Color));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        public int Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                _mileage = value;
                OnPropertyChanged(nameof(Mileage));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        public string Engine
        {
            get
            {
                return _engine;
            }
            set
            {
                _engine = value;
                OnPropertyChanged(nameof(Engine));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }

        public bool CanSubmit => !string.IsNullOrEmpty(Make) &&
            !string.IsNullOrEmpty(Engine) &&
            !string.IsNullOrEmpty(Color) &&
            !string.IsNullOrEmpty(Model) &&
            !string.IsNullOrEmpty(Model) &&
            !Price.Equals(null) &&
            !Mileage.Equals(null) &&
            !Year.Equals(null);

        public ICommand SubmitCommand { get; }

        public ICommand CancelCommand { get; }
    }
}
