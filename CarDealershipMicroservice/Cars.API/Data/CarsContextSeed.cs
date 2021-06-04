using Cars.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.API.Data
{
    public class CarsContextSeed
    {
        public static void SeedAsync(CarsAPIContext carsContext)
        {
            if (!carsContext.Car.Any())
            {
                var movies = new List<Car>
                {
                    new Car
                    {
                        Id = 1,
                        Model = "2",
                        Brand = "Mazda",
                        DateAcquired = new DateTime(2021, 4, 22),
                        PreviousOwners = 1
                    },
                    new Car
                    {
                        Id = 2,
                        Model = "2 Series",
                        Brand = "BMW",
                        DateAcquired = new DateTime(2021, 1, 11),
                        PreviousOwners = 2
                    },
                    new Car
                    {
                        Id = 3,
                        Model = "MX-5",
                        Brand = "Mazda",
                        DateAcquired = new DateTime(2020, 9, 5),
                        PreviousOwners = 1
                    },
                    new Car
                    {
                        Id = 4,
                        Model = "Hilux",
                        Brand = "Toyota",
                        DateAcquired = new DateTime(2019, 10, 5),
                        PreviousOwners = 2
                    },
                    new Car
                    {
                        Id = 5,
                        Model = "Golf",
                        Brand = "Volkswagen",
                        DateAcquired = new DateTime(2020, 6, 7),
                        PreviousOwners = 1
                    },
                    new Car
                    {
                        Id = 6,
                        Model = "Polo",
                        Brand = "Volkswagen",
                        DateAcquired = new DateTime(2021, 5, 5),
                        PreviousOwners = 2
                    },
                    new Car
                    {
                        Id = 7,
                        Model = "Ranger",
                        Brand = "Ford",
                        DateAcquired = new DateTime(2015, 2, 5),
                        PreviousOwners = 4
                    },
                    new Car
                    {
                        Id = 8,
                        Model = "3",
                        Brand = "Mazda",
                        DateAcquired = new DateTime(2021, 5, 5),
                        PreviousOwners = 1
                    }
                };
                carsContext.Car.AddRange(movies);
                carsContext.SaveChanges();
            }
        }
    }
}
