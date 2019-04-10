using Microsoft.AspNetCore.Mvc;
using ReplyRentACarSystem.Api.Models;
using ReplyRentACarSystem.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReplyRentACarSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarService _carService;

        public CarsController(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Car>>> GetAsync()
        {
            return await _carService.GetAsync();
        }

        [HttpGet("{id:length(24)}", Name = "GetCar")]
        public async Task<ActionResult<Car>> GetAsync(string id)
        {
            var Car = await _carService.GetAsync(id);

            if (Car == null)
            {
                return NotFound();
            }

            return Car;
        }

        [HttpPost]
        public async Task<ActionResult<Car>> CreateAsync(Car car)
        {
            await _carService.CreateAsync(car);

            return CreatedAtRoute("GetCar", new { id = car.Id.ToString() }, car);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> UpdateAsync(string id, Car carIn)
        {
            var car = await _carService.GetAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            await _carService.UpdateAsync(id, carIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var car = await _carService.GetAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            await _carService.RemoveAsync(car.Id);

            return NoContent();
        }
    }
}
