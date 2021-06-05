using Cars.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Client.ApiServices
{
    public interface ICarApiService
    {
        Task<IEnumerable<Car>> GetCars();
        Task<Car> GetCar(string id);
        Task<Car> CreateCar(Car car);
        Task<Car> UpdateCar(Car car);
        Task DeleteCar(int id);
    }
}
