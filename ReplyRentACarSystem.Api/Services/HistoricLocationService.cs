using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using ReplyRentACarSystem.Api.Models;
using System.Threading.Tasks;

namespace ReplyRentACarSystem.Api.Services
{
    public class HistoricLocationService
    {
        private readonly IMongoCollection<HistoricLocation> _historicLocations;

        public HistoricLocationService(IConfiguration config)
        {
            var car = new MongoClient(config.GetConnectionString("ReplyRentACarSystemConn"));
            var database = car.GetDatabase("ReplyRentACarSystemDB");
            _historicLocations = database.GetCollection<HistoricLocation>("HistoricLocation");
        }

        public async Task RemoveAsync(string id)
        {
            await _historicLocations.DeleteManyAsync(location => location.CarId == id);
        }

        public async Task<HistoricLocation> CreateAsync(HistoricLocation historicLocation)
        {
            await _historicLocations.InsertOneAsync(historicLocation);
            return historicLocation;
        }
    }
}
