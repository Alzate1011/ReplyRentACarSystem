using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using ReplyRentACarSystem.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReplyRentACarSystem.Api.Services
{
    public class CarService
    {
        private readonly IMongoCollection<Car> _cars;
        private readonly HistoricLocationService _historicLocationService;

        public CarService(IConfiguration config, HistoricLocationService historicLocationService)
        {
            var car = new MongoClient(config.GetConnectionString("ReplyRentACarSystemConn"));
            var database = car.GetDatabase("ReplyRentACarSystemDB");
            _cars = database.GetCollection<Car>("Car");
            _historicLocationService = historicLocationService;
        }

        public async Task<List<Car>> GetAsync()
        {
            return await _cars.Find(car => true).ToListAsync();
        }

        public async Task<Car> GetAsync(string id)
        {
            return await _cars.Find(car => car.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Car> CreateAsync(Car car)
        {
            await _cars.InsertOneAsync(car);
            return car;
        }

        public async Task UpdateAsync(string id, Car carIn)
        {
            await _cars.ReplaceOneAsync(car => car.Id == id, carIn);
        }

        public async Task UpdateLocationAsync(string id, HistoricLocation location)
        {
            var car = await GetAsync(id);

            car.CurrentLocation = location;

            await _historicLocationService.CreateAsync(location);
          
            await _cars.ReplaceOneAsync(c => c.Id == id, car);
        }

        public async Task RemoveAsync(Car carIn)
        {
            await _historicLocationService.RemoveAsync(carIn.Id);
            await _cars.DeleteOneAsync(car => car.Id == carIn.Id);
        }

        public async Task RemoveAsync(string id)
        {
            await _historicLocationService.RemoveAsync(id);
            await _cars.DeleteOneAsync(car => car.Id == id);
        }
    }
}
