using CarFinder.Business.Abstract;
using CarFinder.Business.Concrete;
using CarFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CarFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public List<Car> Get()
        {
            return _carService.GetAllCars();
        }

        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return _carService.GetCarById(id);
        }

        [HttpPost]
        public Car Post([FromBody]Car car)
        {
            return _carService.CreateCar(car);
        }

        [HttpPut]
        public Car Put([FromBody] Car car)
        {

            return _carService.UpdateCar(car);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _carService.DeleteCar(id);
        }

    }
}
