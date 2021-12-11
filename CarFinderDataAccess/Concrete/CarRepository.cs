using CarFinder.Entities;
using CarFinderDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFinderDataAccess.Concrete
{
    public class CarRepository : ICarRepository
    {
        public Car CreateCar(Car car)
        {
            using (var carDbContext=new CarDbContext())
            {
                carDbContext.Cars.Add(car);
                carDbContext.SaveChanges();
                return car;
            }
        }

        public void DeleteCar(int id)
        {
            using (var carDbContext=new CarDbContext())
            {
                var deletedCar = GetCarByID(id);
                carDbContext.Cars.Remove(deletedCar);
                carDbContext.SaveChanges();
            }
        }

        public List<Car> GetAllCars()
        {
            using (var carDbContext=new CarDbContext())
            {
                return carDbContext.Cars.ToList();
            }
        }

        public Car GetCarByID(int id)
        {
            using (var carDbContext=new CarDbContext())
            {
                return carDbContext.Cars.Find(id);
            }
        }

        public Car UpdateCar(Car car)
        {
            using (var carDbContext=new CarDbContext())
            {
                carDbContext.Cars.Update(car);
                carDbContext.SaveChanges();
                return car;
            }
        }
    }
}
