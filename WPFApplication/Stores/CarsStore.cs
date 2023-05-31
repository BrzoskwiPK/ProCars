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


        public CarsStore(ICreateCarCommand createCarCommand, IUpdateCarCommand updateCarCommand, IDeleteCarCommand deleteCarCommand, IGetAllCarsQuery getAllCarsQuery)
        {
            _createCarCommand = createCarCommand;
            _updateCarCommand = updateCarCommand;
            _deleteCarCommand = deleteCarCommand;
            _getAllCarsQuery = getAllCarsQuery;

        }


        public event Action<Car> CarAdded;
        public event Action<Car> CarUpdated;
        public event Action<Car> CarDeleted;

        public async Task Add(Car car)
        {
            await _createCarCommand.Execute(car);

            CarAdded?.Invoke(car);
        }

        public async Task Update(Car car)
        {
            await _updateCarCommand.Execute(car);

            CarUpdated?.Invoke(car);
        }

        public async Task Delete(Guid id)
        {
            await _deleteCarCommand.Execute(id);

            //CarDeleted?.Invoke();
        }
    }
}
