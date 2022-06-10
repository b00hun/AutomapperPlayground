using Ex7_Bartosz_Sadowski.Models;
using System.Collections.Generic;

namespace Ex7_Bartosz_Sadowski.Repository
{
    public interface ICarRepository
    {
        public List<Car> GetAllCars();
    }
}
