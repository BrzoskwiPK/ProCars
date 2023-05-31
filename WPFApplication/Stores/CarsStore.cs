using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WPFApplication.Domain.Commands;
using WPFApplication.Domain.Models;
using WPFApplication.Domain.Queries;

namespace WPFApplication.Stores
{
    public class CarsStore
    {
        private readonly IGetAllCarsQuery _getAllCarsQuery;
        private readonly ICreateCarCommand _createCarCommand;
        private readonly IUpdateCarCommand _updateCarCommand;
        private readonly IDeleteCarCommand _deleteCarCommand;
        private readonly List<Car> _cars;

        public CarsStore(ICreateCarCommand createCarCommand, IUpdateCarCommand updateCarCommand, IDeleteCarCommand deleteCarCommand, IGetAllCarsQuery getAllCarsQuery)
        {
            _createCarCommand = createCarCommand;
            _updateCarCommand = updateCarCommand;
            _deleteCarCommand = deleteCarCommand;
            _getAllCarsQuery = getAllCarsQuery;

            _cars = new List<Car>();
        }


        public IEnumerable<Car> Cars => _cars;

        public event Action CarLoaded;
        public event Action<Car> CarAdded;
        public event Action<Car> CarUpdated;
        public event Action<Guid> CarDeleted;
        public async Task Load()
        {
            IEnumerable<Car> cars = await _getAllCarsQuery.Execute();

            _cars.Clear();
            _cars.AddRange(cars);

            CarLoaded?.Invoke();
        }

        public async Task Add(Car car)
        {
            await _createCarCommand.Execute(car);

            _cars.Add(car);

            CarAdded?.Invoke(car);
        }

        public async Task Update(Car car)
        {
            await _updateCarCommand.Execute(car);

            int currentIndex = _cars.FindIndex(y => y.Id == car.Id);

            if (currentIndex != -1)
            {
                _cars[currentIndex] = car;
            }
            else
            {
                _cars.Add(car);
            }

            CarUpdated?.Invoke(car);
        }

        public async Task Delete(Guid id)
        {
            await _deleteCarCommand.Execute(id);

            _cars.RemoveAll(y => y.Id == id);

            CarDeleted?.Invoke(id);
        }
    }
}
