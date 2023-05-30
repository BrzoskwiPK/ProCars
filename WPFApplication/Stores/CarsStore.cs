using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApplication.Models;

namespace WPFApplication.Stores
{
    public class CarsStore
    {
        public event Action<Car> CarAdded;
        public event Action<Car> CarUpdated;
        public async Task Add(Car car)
        { 
            CarAdded?.Invoke(car);
        }

        public async Task Update(Car car)
        {
            CarUpdated?.Invoke(car);
        }
    }
}
