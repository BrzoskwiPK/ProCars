using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApplication.ViewModels
{
    public class CarsDetailsViewModel
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }
        public int Mileage { get; }
        public string Engine { get; }
        public decimal Price { get; }

        public CarsDetailsViewModel()
        {
            Make = "Toyota";
            Model = "Supra";
            Year = 1960;
            Color = "Red";
            Mileage = 192000;
            Engine = "V8";
            Price = 120500;
        }
    }
}
