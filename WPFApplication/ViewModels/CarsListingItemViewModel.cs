using System.Windows.Input;

namespace WPFApplication.ViewModels
{
    public class CarListingItemViewModel : ViewModelBase
    {
        public string Make { get;  }
        public string Model { get; }
        public string Engine { get; }
        public int Year { get; }
        public int Mileage { get; }
        public string Color { get; }
        public decimal Price { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public CarListingItemViewModel(string make, string model, string engine, int year, int mileage, string color, decimal price)
        {
            Make = make;
            Model = model;
            Engine = engine;
            Year = year;
            Mileage = mileage;
            Color = color;
            Price = price;
        }
    }
}
