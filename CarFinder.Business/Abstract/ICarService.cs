using CarFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFinder.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        Car CreateCar(Car car);
        Car UpdateCar(Car car);
        void DeleteCar(int id);

    }
}
