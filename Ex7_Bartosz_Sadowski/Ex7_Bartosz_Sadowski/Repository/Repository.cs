using Ex7_Bartosz_Sadowski.Models;
using System.Collections.Generic;

namespace Ex7_Bartosz_Sadowski.Repository
{
    public class CarRepository : ICarRepository
    {
        private static readonly List<Car> _cars = new()
        {
            new Car
            {
                Id = 1,
                Company = "BMW",
                Model = "z3",
                Vmax = 280,
                Unit = "km/h",
                IsHybrid = false,
                YearOfProduction = 2005,
                Stars = 8,
                Price = 200000,
                Currency = "usd",
                Description = "Małe sportowe auto"

            },
            new Car
            {
                Id = 2,
                Company = "Audi",
                Model = "E3",
                Vmax = 350,
                Unit = "km/h",
                IsHybrid = true,
                YearOfProduction = 2022,
                Stars = 6,
                Price = 400000,
                Currency = "eur",
                Description = "Małe elektryczne auto"


            }
        };

        public List<Car> GetAllCars()
        {
            var cars = _cars;
            return cars;
        }
    }
    
}
