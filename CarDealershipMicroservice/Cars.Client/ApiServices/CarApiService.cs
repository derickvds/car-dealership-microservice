using Cars.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Client.ApiServices
{
    public class CarApiService : ICarApiService
    {
        public Task<Car> CreateCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCar(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Car>> GetCars()
        {
            var carList = new List<Car>();
            carList.Add(
                    new Car
                    {
                        Id = 1,
                        Model = "2",
                        Brand = "Mazda",
                        DateAcquired = new DateTime(2021, 4, 22),
                        PreviousOwners = 1
                    }
                );

            return await Task.FromResult(carList);
        }

        public Task<Car> UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
