using CarFinder.Business.Abstract;
using CarFinder.Entities;
using CarFinderDataAccess.Abstract;
using CarFinderDataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFinder.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarRepository _carRepository;
        public CarManager(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public Car CreateCar(Car car)
        {
            return _carRepository.CreateCar(car);
        }

        public void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Car GetCarById(int id)
        {
            if (id>0)
            {
                return _carRepository.GetCarByID(id);
            }

            throw new Exception("id 1'den küçük olamaz");
        }

        public Car UpdateCar(Car car)
        {
            return _carRepository.UpdateCar(car);
        }
    }
}
