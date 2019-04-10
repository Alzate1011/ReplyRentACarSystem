using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ReplyRentACarSystem.Api.Models
{
    public class Demand
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int UserId { get; set; }
        public string CreateDate { get; set; }
        public Location PickUpLocation { get; set; }
        public Location DropOffLocation { get; set; }
        public string EarliestPickUpTime { get; set; }
        public string LatestDropOffTime { get; set; }
        public DesiredFeatures DesiredFeatures { get; set; }
    }
}
